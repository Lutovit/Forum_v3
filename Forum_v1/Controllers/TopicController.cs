﻿using Forum_v1.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Repository.Absract;
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum_v1.Controllers
{
    public class TopicController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ITopicRepository _topicRepo;
        private readonly IMessageRepository _messageRepo;
        




        public TopicController(UserManager<ApplicationUser> userManager, ITopicRepository topicRepo, IMessageRepository messageRepo)
        {
            _userManager = userManager;
            _topicRepo = topicRepo;
            _messageRepo = messageRepo;
        }


        
        public async Task<IActionResult> Index() 
        {
            return View(await _topicRepo.GetAllWithIncludeMessagesAsync());
        }



        [HttpGet]
        [Authorize]
        public IActionResult CreateTopic() 
        {
            return View();        
        }



        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CreateTopic(TopicCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = await _userManager.FindByEmailAsync(User.Identity.Name);

                if (user == null) 
                {
                    ModelState.AddModelError(string.Empty, "Объект User  не найден!");
                }

                Topic topic = new Topic {  TopicName = model.TopicName, TopicDescription = model.TopicDescription, User = user, ApplicationUserId = user.Id };

                if (topic == null) 
                {
                    ModelState.AddModelError(string.Empty, "Объект Topic не создан!");
                }

                await _topicRepo.CreateAsync(topic);

                return RedirectToAction("Index", "Topic");

            }
            return View(model);
        }



     
        public async Task<IActionResult> EnterIntoTopic(int Id) 
        {
            string email = User.Identity.Name;

            ApplicationUser user = null;

            if (email != null)
            {
              user  = await _userManager.FindByEmailAsync(email);
            }
            
            if (user != null)
            {
                IList<string> _rolelist = await _userManager.GetRolesAsync(user);

                bool isAdmin = false;

                if (_rolelist.Contains("admin"))
                {
                    isAdmin = true;
                }

                if (isAdmin)
                {
                    return RedirectToAction("AdminsTopicsViewing", "Topic", new {topicId = Id});
                }
            }

            return View(await _topicRepo.FindByIdWithIncludeMessagesAsync(Id));           
        }




        [Authorize(Roles = "admin")]     
        public async Task<ActionResult> AdminsTopicsViewing(int topicId)
        {
            return View(await _topicRepo.FindByIdWithIncludeMessagesAsync(topicId));
        }



        [HttpGet]
        [Authorize]
        public async Task<IActionResult> CreateNewMessage()
        {
            ApplicationUser user = await _userManager.FindByEmailAsync(User.Identity.Name);

            if (user != null)
            {
                MessageCreateViewModel cm = new MessageCreateViewModel
                {
                    Date = DateTime.Now.ToString(),
                    ClientName = user.ClientName
                };

                return View(cm);
            }

            return RedirectToAction("Index");     
        }


        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CreateNewMessage(string text, int topicId) 
        {
            ApplicationUser user = await _userManager.FindByNameAsync(User.Identity.Name);

            if (user == null ) 
            {
                return RedirectToAction("Index", "Topic");
            }

            if (text == null)
            {
                return RedirectToAction("EnterIntoTopic", "Topic", new { Id = topicId});
            }

            Message mes = new Message()
            {  
                TopicId = topicId,
                ApplicationUserId = user.Id,
                Text=text,
                UserName=user.Email
            };

            await _messageRepo.CreateAsync(mes);

            return RedirectToAction("Index", "Topic");

        }



        [HttpGet]
        [Authorize]
        public async Task<ActionResult> EditMessage(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }            

            Message message = await _messageRepo.FindByIdWithIncludeUserAsync((int)id);

            if (message == null)
            {
                return NotFound();
            }

            ApplicationUser user = await _userManager.FindByEmailAsync(User.Identity.Name);

            bool isAdmin = false;

            if (user != null)
            {
                IList<string> _rolelist = await _userManager.GetRolesAsync(user);

                if (_rolelist.Contains("admin"))
                {
                    isAdmin = true;
                }
            }

            if (user != null && message.ApplicationUserId != user.Id && isAdmin == false)
            {
                return View("YouCanEditOnlyYourMessage");
            }

            MessageEditViewModel model = new MessageEditViewModel
            {
                Id = message.Id,
                ApplicationUserId = message.ApplicationUserId,
                DateOfCreate = message.Date.ToString(),
                ClientName = message.User.ClientName,
                Text = message.Text
            };

            return View(model);
        }



        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditMessage(MessageEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                Message message = await _messageRepo.FindByIdAsync(model.Id);

                if (message == null)
                {
                    return NotFound();
                }

                message.isEdited = true;
                message.DateOfLastEdit = DateTime.Now;
                message.Text = model.Text;


                await _messageRepo.UpdateAsync(message);

                return RedirectToAction("Index");
            }
            return View(model);
        }



        [HttpGet]
        [Authorize]
        public async Task<ActionResult> DeleteMessage(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Message message = await _messageRepo.FindByIdAsync((int)id);

            if (message == null)
            {
                return NotFound();
            }

            ApplicationUser user = await _userManager.FindByEmailAsync(User.Identity.Name);

            bool isAdmin = false;

            if (user != null)
            {
                IList<string> _rolelist = await _userManager.GetRolesAsync(user);

                if (_rolelist.Contains("admin"))
                {
                    isAdmin = true;
                }
            }

            if (user != null && message.ApplicationUserId != user.Id && isAdmin == false)
            {
                return View("YouCanDeleteOnlyYourMessage");
            }

            return View(message);
        }



        [Authorize]
        [HttpPost, ActionName("DeleteMessage")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteMessageConfirmed(int id)
        {
            Message message = await _messageRepo.FindByIdAsync((int)id);
            await _messageRepo.RemoveAsync(message);
            
            return RedirectToAction("Index");
        }
    }
}
