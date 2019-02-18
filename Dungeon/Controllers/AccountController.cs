using Dungeon.Data.Identity;
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

        // Login
        // Logout
        // Register
        // EditDetails
        // DeleteAccount
    }
}