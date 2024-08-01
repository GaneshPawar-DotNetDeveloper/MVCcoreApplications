using Microsoft.AspNetCore.Mvc;

namespace Core8app.Controllers
{
    // [Route("Ganesh/Pawar")]
    // [Route("[controller]")]
    [Route("Product")]
    public class ProductController : Controller
    {
        
       public IActionResult Index()
        {
            return View();
        }
        [Route("detail/{Id}")]
        public string detail(int Id)
        {
            return $" You Entered {Id}";
        }
        [Route("ProductCategary/{catId}")]
        public string ProductCategary( int catId)

        {

            return $"All Categary Product is {catId}";
        }
    }
}
