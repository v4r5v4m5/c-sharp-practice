using Microsoft.AspNetCore.Mvc;

namespace mvc.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login(string? username, string? password)
        {
            if (username == null || password == null) return Content("Please login by providing Account/Login?username={your_username}&password={your_password}");
            if (username == "admin" && password == "pwd") return RedirectToAction("Dashboard", "Admin");
            else return RedirectToAction("InvalidLogin");
        }

        public IActionResult InvalidLogin() 
        {
            return View();
        }
    }
}
