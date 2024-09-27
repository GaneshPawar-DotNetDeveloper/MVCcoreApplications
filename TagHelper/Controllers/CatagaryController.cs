using Microsoft.AspNetCore.Mvc;

namespace TagHelper.Controllers
{
    public class CatagaryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CatagaryList()
        {

            return View();
        }
    }
}
