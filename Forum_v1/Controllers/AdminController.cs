using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Forum_v1.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Repository.Absract;
using Repository.Entities;

namespace Forum_v1.Controllers
{
    public class AdminController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IBanRepository _banRepo;
        private readonly SignInManager<ApplicationUser> _signInManager;


        public AdminController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager,
            IBanRepository banRepo, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _banRepo = banRepo;
            _signInManager = signInManager;
        }
        



        [Authorize(Roles = "admin")]
        // GET: Admin
        public ActionResult Index()
        {
            return View(_userManager.Users);
        }




        [Authorize(Roles = "admin")]
        public async Task<ActionResult> Info(string Id)
        {
            ApplicationUser user = await _userManager.FindByIdAsync(Id);

            if (user != null)
            {
                IList<string> _rolelist = await _userManager.GetRolesAsync(user);

                AdminInfo model = new AdminInfo { UserName = user.ClientName, UserEmail = user.Email, UserRoleList = _rolelist, CompanyName = user.CompanyName };

                ViewBag.id = user.Id;

                return View(model);
            }
            else
            {
                ModelState.AddModelError("", "Что-то пошло не так");
            }

            return RedirectToAction("Index");

        }


        [Authorize(Roles = "admin")]
        public async Task<ActionResult> Edit(string id)
        {
            ApplicationUser user = await _userManager.FindByIdAsync(id);

            if (user == null)
            {
                ModelState.AddModelError("", "Cant find user!");
                return RedirectToAction("Index");
            }

            IEnumerable<string> userRoleList = await _userManager.GetRolesAsync(user);         

            IEnumerable<string> availableRoles = _roleManager.Roles.Select(r => r.Name);

            AdminEdit model = new AdminEdit
            {
                UserName = user.ClientName,
                UserEmail = user.Email,
                UserRoleList = userRoleList.ToList(),
                RoleList = availableRoles.ToList(),
                CompanyName = user.CompanyName
            };

            return View(model);           

        }




        [Authorize(Roles = "admin")]
        public async Task<ActionResult> AddRoleToUser(string Email, string Rolename)
        {
            ApplicationUser user = await _userManager.FindByEmailAsync(Email);

            if (user != null)
            {
                await _userManager.AddToRoleAsync(user, Rolename);
                return RedirectToAction("Edit", "Admin", new { Id = user.Id });
            }
            else
            {
                ModelState.AddModelError("", "Cant add role to user!");
            }

            return RedirectToAction("Index");
        }



        [Authorize(Roles = "admin")]
        public async Task<ActionResult> DeleteRoleFromUser(string Email, string Rolename)
        {
            ApplicationUser user = await _userManager.FindByEmailAsync(Email);

            if (user != null)
            {
                await _userManager.RemoveFromRoleAsync(user, Rolename);
                return RedirectToAction("Edit", "Admin", new { Id = user.Id });
            }
            else
            {
                ModelState.AddModelError("", "Cant delete role from user!");
            }

            return RedirectToAction("Index");

        }


        [Authorize(Roles = "admin")]
        [HttpGet]
        public ActionResult DeleteUser()
        {
            return View();
        }


        [Authorize(Roles = "admin")]
        [HttpPost]
        public async Task<ActionResult> DeleteUser(string Id)
        {

            ApplicationUser user = await _userManager.FindByIdAsync(Id);

            if (user != null)
            {
               
                if (await _userManager.IsInRoleAsync(user, "admin"))
                {
                    return RedirectToAction("AdminSelfDelete");
                }

                user.isDelited = true;

                await _userManager.UpdateSecurityStampAsync(user);

                await _userManager.UpdateAsync(user);

                return RedirectToAction("Index", "Admin");

            }
            return RedirectToAction("CantDeleteUser", new { name = user.Email });

        }



        [Authorize(Roles = "admin")]
        [HttpGet]
        public ActionResult RecoverUser()
        {
            return View();
        }



        [Authorize(Roles = "admin")]
        [HttpPost]
        public async Task<ActionResult> RecoverUser(string Id)
        {

            ApplicationUser user = await _userManager.FindByIdAsync(Id);

            if (user != null)
            {

                user.isDelited = false;

                await _userManager.UpdateSecurityStampAsync(user);

                await _userManager.UpdateAsync(user);

                return RedirectToAction("Index", "Admin");

            }
            return RedirectToAction("CantRecoverUser", new { name = user.Email });

        }




        [Authorize(Roles = "admin")]
        public string CantDeleteUser(string name)
        {
            return "Не могу удалить пользователя:  " + name + "  Что-то пошло не так!";
        }




        [Authorize(Roles = "admin")]
        public string CantRecoverUser(string name)
        {
            return "Не могу удалить пользователя:  " + name + "  Что-то пошло не так!";
        }




        [Authorize(Roles = "admin")]
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }



        [Authorize(Roles = "admin")]
        public async Task<ActionResult> Create(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = new ApplicationUser { UserName = model.Email, Email = model.Email, ClientName = model.ClientName, CompanyName = model.CompanyName };

                IdentityResult result = await _userManager.CreateAsync(user, model.Password);


                if (result.Succeeded)
                {
                    // если создание прошло успешно, то добавляем роль пользователя
                    await _userManager.AddToRoleAsync(user, "user");

                    return RedirectToAction("Index", "Admin");
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



        [Authorize(Roles = "admin")]
        public async Task<ActionResult> FindByEmail(string email)
        {
            if (email != null)
            {
                ApplicationUser user = await _userManager.FindByEmailAsync(email);
                if (user != null)
                {
                    return RedirectToAction("Edit", "Admin", new { Id = user.Id });
                }
                else
                {
                    return RedirectToAction("NoUserEmail", "Admin");
                }
            }
            else 
            {
               return  RedirectToAction("Index", "Admin");
            }            
        }


        [Authorize(Roles = "admin")]
        public ActionResult NoUserEmail()
        {
            return View();
        }




        [Authorize(Roles = "admin")]
        [HttpGet]
        public ActionResult BanUser()
        {
            return View();
        }




        [Authorize(Roles = "admin")]
        [HttpPost]
        public async Task<ActionResult> BanUser(string Id)
        {
            ApplicationUser user = await _userManager.FindByIdAsync(Id);

            if (user != null)
            {
                if (user.isBanned == true)
                {
                    return RedirectToAction("Index", "Admin");
                }

                user.isBanned = true;

                // enables immediate logout, after updating the user's stat.
                await _userManager.UpdateSecurityStampAsync(user);

                await _userManager.UpdateAsync(user);

                BanEmail banEmail = new BanEmail { Email = user.Email };

                await _banRepo.CreateAsync(banEmail);

                return RedirectToAction("Index", "Admin");
            }

            return RedirectToAction("CantBanUser", new { name = user.Email });
        }



        [Authorize(Roles = "admin")]
        public string CantBanUser(string name)
        {
            return "Не могу забанить пользователя:  " + name + "  Что-то пошло не так!";
        }



        [Authorize(Roles = "admin")]
        public string CantCancelBan(string email)
        {
            return "Не могу снять бан с пользователя:  " + email + "  Что-то пошло не так!";
        }



        [Authorize(Roles = "admin")]
        public IActionResult AdminSelfDelete()
        {
            return View();
        }



        [Authorize(Roles = "admin")]
        // GET: Admin
        public async Task<ActionResult> BanUsersList()
        {
            return View(await _banRepo.GetAllAsync());
        }




        [Authorize(Roles = "admin")]
        // GET: Admin
        public async Task<ActionResult> CancelBan(string email)
        {
            ApplicationUser user = await _userManager.FindByEmailAsync(email);

            if (user != null)
            {
                user.isBanned = false;
                await _userManager.UpdateAsync(user);
            }

            BanEmail banEmail = await _banRepo.FindByEmailAsync(user.Email);

            if (banEmail != null)
            {
                await _banRepo.RemoveAsync(banEmail);

                return RedirectToAction("BanUsersList");
            }

            return RedirectToAction("CantCancelBan");
        }
    }
}