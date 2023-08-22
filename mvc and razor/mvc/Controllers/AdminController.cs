using Microsoft.AspNetCore.Mvc;

namespace mvc.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
