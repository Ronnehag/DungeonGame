using System.Reflection.Metadata.Ecma335;
using Dungeon.Data.Identity;
using Dungeon.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
namespace Dungeon.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _usermanager;
        private readonly SignInManager<AppUser> _signinManager;

        public AccountController(UserManager<AppUser> usermanager, SignInManager<AppUser> signinManager)
        {
            _usermanager = usermanager;
            _signinManager = signinManager;
        }

        // Register View
        public IActionResult RegisterAccount()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RegisterAccount(RegisterAccountViewModel model)
        {
            // If invalid model, return current view.
            if (!ModelState.IsValid)
            {
                return PartialView("_RegisterAccountForm", model);
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

            // If user can't be created, append the errors on the model and return the view.
            if (!create.Succeeded)
            {
                foreach (var error in create.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return PartialView("_RegisterAccountForm", model);
            }
            await _signinManager.SignInAsync(user, isPersistent: false);
            return RedirectToAction("Index", "Home");
        }



        // Logout

        // EditDetails
        // DeleteAccount

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }

            var user = await _usermanager.FindByNameAsync(model.Username);
            if (user == null) return RedirectToAction("Index", "Home");

            var result = await _signinManager.PasswordSignInAsync(user, model.Password, false, false);

            return RedirectToAction("Index", "Home");
        }
    }
}