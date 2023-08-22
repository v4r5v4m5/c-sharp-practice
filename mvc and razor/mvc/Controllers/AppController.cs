using Microsoft.AspNetCore.Mvc;

namespace mvc.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Products()
        {
            return View();
        }

        public IActionResult Contact() 
        {
            return View();
        }
    }
}
