using Microsoft.AspNetCore.Mvc;
using mvc.Models;
using System.Diagnostics;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.Extensions.Hosting;

namespace mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment _hostingEnvironment;


        public HomeController(ILogger<HomeController> logger, IWebHostEnvironment hostingEnvironment)
        {
            _logger = logger;
            _hostingEnvironment = hostingEnvironment;
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
        
        public IActionResult RequestExample()
        {
            
            ViewBag.Url = Request.GetDisplayUrl();
            ViewBag.PAP = _hostingEnvironment.ContentRootPath;
            ViewBag.Path = Request.Path;
            /*ViewBag.BrowserType = HttpContext.Request.;*/
            ViewBag.Query = Request.Query["n"];
            ViewBag.Header = Request.Headers["Accept"];
            ViewBag.HttpMethod = HttpContext.Request.Method;

            return View();
        }

        public IActionResult ResponseExample()
        {
            /*Response.ContentType = "text/plain";*/
            ViewBag.Url = Request.GetDisplayUrl();
            ViewBag.Server = Response.Headers["Server"] = "server is hacked";
            /*ViewBag.Server = _hostingEnvironment.ContentRootPath;*/
            ViewBag.Path = Request.Path;
            /*ViewBag.BrowserType = HttpContext.Request.;*/
            ViewBag.Query = Request.Query["n"];
            ViewBag.Header = Request.Headers["Accept"];
            ViewBag.HttpMethod = HttpContext.Request.Method;

            return View();
        }
    }
}