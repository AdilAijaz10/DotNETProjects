using FormUsingTagHelper.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FormUsingTagHelper.Controllers
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
        [HttpPost]
        public string Index(Employee emp)
        {
            return "Name: " + emp.Name + "\nGender: " + emp.Gender + "\nAge: " + emp.Age + 
                "\nDesignation: " + emp.Designation + "\nSalary" + emp.Salary + "\nMarried" 
                + emp.Married + "\nDescription: " + emp.Description;
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
    }
}
