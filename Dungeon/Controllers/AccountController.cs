using Dungeon.Data.Identity;
using Dungeon.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
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
        public IActionResult RegisterAccount(RegisterAccount model)
        {
            if (!ModelState.IsValid)
            {
                return PartialView("_RegisterAccountForm", model);
            }
            // TODO
            // Create user account, map it with character, map character with stats.
            // Add Service Classes

            return null;
        }




        // Login
        // Logout
        
        // EditDetails
        // DeleteAccount
    }
}