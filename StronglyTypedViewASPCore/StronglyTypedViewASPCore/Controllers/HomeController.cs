using Microsoft.AspNetCore.Mvc;
using StronglyTypedViewASPCore.Models;
using System.Diagnostics;

namespace StronglyTypedViewASPCore.Controllers
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
            //Employee obj = new Employee()
            //{
            //    EmpId = 1,
            //    EmpName = "Adil",
            //    Designation = "Manager",
            //    Salary = 450000
            //};
            var obj = new List<Employee>()
            {
                new Employee{EmpId =1, EmpName ="Adil", Designation = "Manager", Salary = 400000},
                new Employee{EmpId =2, EmpName ="Ali", Designation = "SR Manager", Salary = 600000},
                new Employee{EmpId =3, EmpName ="Ahmed", Designation = "Manager", Salary = 400000},
                new Employee{EmpId =4, EmpName ="Umer", Designation = "SR Manager", Salary = 600000},
            };

            return View(obj);
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
