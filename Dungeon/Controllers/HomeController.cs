using Microsoft.AspNetCore.Mvc;

namespace Dungeon.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}