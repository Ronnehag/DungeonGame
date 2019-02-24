using System.Reflection.Metadata.Ecma335;
using Dungeon.Data.Identity;
using Dungeon.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Dungeon.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _usermanager;
        private readonly SignInManager<AppUser> _signinManager;

        public AccountController(UserManager<AppUser> usermanager, SignInManager<AppUser> signinManager)
        {
            _usermanager = usermanager;
            _signinManager = signinManager;
        }

        [AllowAnonymous]
        public IActionResult RegisterAccount()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RegisterAccount(RegisterAccountViewModel model)
        {
            // If invalid details, return current view.
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // Else create the Identity and store it
            var user = new AppUser
            {
                Email = model.Email,
                UserName = model.UserName,
                NormalizedEmail = model.Email.ToLower(),
                NormalizedUserName = model.UserName.ToLower()
            };
            var create = await _usermanager.CreateAsync(user, model.Password);

            // If user can't be created, append the errors on the details and return the view.
            if (!create.Succeeded)
            {
                foreach (var error in create.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                return View(model);
            }
            await _signinManager.SignInAsync(user, isPersistent: false);
            return RedirectToAction("Index", "Home");
        }


        // EditDetails
        // DeleteAccount

        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel details)
        {
            if (ModelState.IsValid)
            {
                var user = await _usermanager.FindByNameAsync(details.Username);
                if (user != null)
                {
                    var result = await _signinManager.PasswordSignInAsync(user, details.Password, false, false);
                    if (result.Succeeded)
                    {
                        return Redirect("/");
                    }
                }
                ModelState.AddModelError(nameof(LoginViewModel.Username), "Invalid username or password");
            }
            return View(details);
        }


        public async Task<IActionResult> LogOut()
        {
            await _signinManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }


        public IActionResult AccountDetails()
        {
            return View();
        }
    }
}