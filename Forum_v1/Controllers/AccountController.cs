﻿using System.Threading.Tasks;
using Forum_v1.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Repository.Entities;
using Repository.Absract;
using Microsoft.AspNetCore.Authentication;
using System.Collections.Generic;
using System.Linq;

namespace Forum_v1.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IBanRepository _banRepo;

        
       


        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager,
            RoleManager<IdentityRole> roleManager, IBanRepository banRepo)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _banRepo = banRepo;
        }

        
        [HttpGet]
        public async Task<IActionResult> Register()
        {

            IdentityRole roleUser = await _roleManager.FindByNameAsync("user");

            if (roleUser == null)
            {
                IdentityResult result = await _roleManager.CreateAsync(new IdentityRole
                {
                    Name = "user" 
                });

                if (result.Succeeded)
                {
                    return View();
                }
                else
                {
                    ModelState.AddModelError("", "Что-то пошло не так");
                }

            }

            return View();

        }
        


        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = new ApplicationUser { Email = model.Email, UserName = model.Email, ClientName = model.ClientName, CompanyName=model.CompanyName };
                
                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {                    
                    await _signInManager.SignInAsync(user, false);
                    await _userManager.AddToRoleAsync(user, "user");
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            return View(model);
        }




        [HttpGet]
        public async Task<IActionResult> Login(string returnUrl = null)
        {
            // Clear the existing external cookie to ensure a clean login process
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);
            IList<AuthenticationScheme> externalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();        

            return View(new LoginViewModel { ReturnUrl = returnUrl, ExternalLogins = externalLogins });
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = await _userManager.FindByEmailAsync(model.Email);

                if (user == null) 
                {
                    ModelState.AddModelError("", "There is no account with such Email!");
                    return View(model);
                }

                if (user.isDelited == true)
                {
                    return RedirectToAction("DeletedAccount");
                }

                if (user.isBanned == true)
                {
                    return RedirectToAction("YouhaveBan");
                }

                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);

                if (result.Succeeded)
                {
                    // проверяем, принадлежит ли URL приложению
                    if (!string.IsNullOrEmpty(model.ReturnUrl) && Url.IsLocalUrl(model.ReturnUrl))
                    {
                        return Redirect(model.ReturnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Неправильный логин и (или) пароль");
                }
            }
            return View(model);
        }


        // Post: /Account/Logout
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            // удаляем аутентификационные куки
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }



        // Get: /Account/Log_Off
        [Authorize]
        public async Task<IActionResult> Log_Off()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }




        public IActionResult Delete() 
        {
            return View();        
        }


        [Authorize]
        [HttpPost]
        [ActionName("Delete")]
        public async Task<ActionResult> DeleteConfirmed()
        {
            ApplicationUser user = await _userManager.FindByEmailAsync(User.Identity.Name);

            if (user != null)
            {
                user.isDelited = true;
                await _userManager.UpdateAsync(user);
                await _signInManager.SignOutAsync();                
            }
            return RedirectToAction("Index", "Home");
        }



        [AllowAnonymous]
        public ActionResult YouhaveBan()
        {
            return View();
        }



        [AllowAnonymous]
        public ActionResult DeletedAccount()
        {
            return View();
        }


    }
}