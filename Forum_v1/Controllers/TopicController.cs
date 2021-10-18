using Forum_v1.Models;
using Forum_v1.Services;
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
        private readonly IPagination _paginationService;





        public TopicController(UserManager<ApplicationUser> userManager, ITopicRepository topicRepo, IMessageRepository messageRepo, IPagination paginationService)
        {
            _userManager = userManager;
            _topicRepo = topicRepo;
            _messageRepo = messageRepo;
            _paginationService = paginationService;
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

                Topic topic = new Topic {  TopicName = model.TopicName, TopicDescription = model.TopicDescription,
                    User = user, ApplicationUserId = user.Id };

                if (topic == null) 
                {
                    ModelState.AddModelError(string.Empty, "Объект Topic не создан!");
                }

                await _topicRepo.CreateAsync(topic);

                return RedirectToAction("Index", "Topic");

            }
            return View(model);
        }



     
        public async Task<IActionResult> EnterIntoTopic(int topic_Id, int page=1) 
        {
            if (await IsAdmin())
            {
                return RedirectToAction("AdminsTopicsViewing", "Topic",
                    new { topicId = topic_Id, _page = page });
            }
            else 
            {
                return View(await _paginationService.PaginateMessages(topic_Id, page));
            }     
        }




        private async Task<bool> IsAdmin() 
        {
            string email = User.Identity.Name;            

            if (email == null)
            {
                return false;
            }
            
            var user = await _userManager.FindByEmailAsync(email);

            if (user == null)
            {
                return false; 
            }

            IList<string> _rolelist = await _userManager.GetRolesAsync(user);            

            if (_rolelist.Contains("admin"))
            {
                return true;
            }
 
            return false;
        }



        [Authorize(Roles = "admin")]     
        public async Task<ActionResult> AdminsTopicsViewing(int topicId, int _page=1)
        {
            return View(await _paginationService.PaginateMessages(topicId, _page));
        }



        [HttpGet]
        [Authorize]
        public async Task<IActionResult> CreateNewMessage(int topicId)
        {
            ApplicationUser user = await _userManager.FindByEmailAsync(User.Identity.Name);

            if (user != null)
            {
                MessageCreateViewModel model = new MessageCreateViewModel
                {
                    Date = DateTime.Now.ToString(),
                    ClientName = user.ClientName, 
                    TopicId=topicId
                };

                return View(model);
            }

            return RedirectToAction("Index");     
        }


        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CreateNewMessage(MessageCreateViewModel model) 
        {
            ApplicationUser user = await _userManager.FindByNameAsync(User.Identity.Name);

            if (user == null ) 
            {
                return RedirectToAction("Index", "Topic");
            }

            if (ModelState.IsValid)
            {

                Message mes = new Message()
                {
                    TopicId = model.TopicId,
                    ApplicationUserId = user.Id,
                    Text = model.Text,
                    UserName = user.Email
                };

                await _messageRepo.CreateAsync(mes);

                return RedirectToAction("EnterIntoTopic", "Topic", new { topic_Id = model.TopicId });
            }
            else 
            {
                return View(model);            
            }  
        }



        [HttpGet]
        [Authorize]
        public async Task<ActionResult> EditMessage(int? id, int curPage)
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
                Text = message.Text,
                TopicId=message.TopicId, 
                pageNum=curPage
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

                return RedirectToAction("EnterIntoTopic", "Topic", new { topic_Id = model.TopicId, page=model.pageNum });
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

            int topicId = message.TopicId;

            await _messageRepo.RemoveAsync(message);

            return RedirectToAction("EnterIntoTopic", "Topic", new { topic_Id = topicId});
        }
    }
}
