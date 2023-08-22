using Microsoft.AspNetCore.Mvc;

namespace mvc.Controllers
{
    public class ActionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // content result
        public IActionResult GetEmpName(int empId)
        {
            var employees = new[] { 
                new {empId = 1, empName = "Steve Jobs", Salary = 8000},
                new {empId = 2, empName = "Zuck", Salary = 10000},
                new {empId = 3, empName = "DQ", Salary = 100000}
            };

            string matchEmpName = null;

            foreach (var emp in employees)
            {
                if (emp.empId == empId) matchEmpName = emp.empName;
                else matchEmpName = "id not found";
            }
            return Content(matchEmpName, "text/plain");
        }
        public IActionResult GetEmpDetails(int empId)
        {
            var employees = new[] { 
                new {empId = 1, empName = "Steve Jobs", Salary = 8000},
                new {empId = 2, empName = "Zuck", Salary = 10000},
                new {empId = 3, empName = "DQ", Salary = 100000}
            };

            string matchEmpName = null;
            object entry = null;

            foreach (var emp in employees)
            {
                if (emp.empId == empId) entry = $"employee ID is {emp.empId}\nemployee name is {emp.empName}\nemployee salary is {emp.Salary}";
                else entry = "id doesn't exist";
            }
            return Content(entry.ToString(), "text/plain");
        }

       
        // file result
        public IActionResult GetPaySlip(int empId)
        {
            string fileName = "~/PaySlip" + empId + ".pdf";
            string fullPath = @"C:\Users\SAILS-DM347\Downloads\PaySlip.pdf";
            if (System.IO.File.Exists(fullPath)) {
                Console.WriteLine($"{fullPath} file exists");
            }
            else
            {
                Console.WriteLine($"{fullPath} file doesn't exist");
            }
            return File(fullPath, "application/pdf", "PaySlip.pdf");
        }

        // redirect result
        [Route("Action/TakeToPage/{web?}")]
        public IActionResult TakeToPage(string? web)
        {
            if (string.IsNullOrEmpty(web)) return Content("type website name as the pattern to redirect\n(TakeToPage/{website name})");
            string url = "https://www." + web + ".com";
            return Redirect(url);
        }



    }
}
