using Microsoft.AspNetCore.Mvc;
using mvc.Models;
using System.Diagnostics;
using System.Collections.Generic;

namespace mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult StudentDetails()
        {
            ViewBag.StuName = "DQ";
            ViewBag.Age = 18;
            ViewBag.Marks = 99;
            ViewBag.NoOfSemesters = 6;

            // collection
            ViewBag.Subjects = new List<string>() { "Maths", "Physics", "Chemistry" };
            return View();
        }
        
    }
}