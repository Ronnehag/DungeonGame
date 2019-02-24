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

        // Register
        public IActionResult RegisterAccount()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RegisterAccount(RegisterAccount model)
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




        // Login
        // Logout

        // EditDetails
        // DeleteAccount
    }
}