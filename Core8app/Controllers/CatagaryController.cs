using Microsoft.AspNetCore.Mvc;

namespace Core8app.Controllers
{
    public class CatagaryController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Name"] = "Ganesh";
            ViewBag.Email = "Ganesh.netdevloper.com";
            TempData["FreedomFighter"] = "Bal gangadhar Tilak";
            return View();
        }

        public IActionResult Details() {

            ViewBag.FreedomFighter = TempData["FreedomFighter"];   

            return View();
        }
    }
}
