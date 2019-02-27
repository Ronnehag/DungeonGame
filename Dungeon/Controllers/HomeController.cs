using Microsoft.AspNetCore.Mvc;

namespace Dungeon.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        [Route("Index")]
        [Route("Home/Index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}