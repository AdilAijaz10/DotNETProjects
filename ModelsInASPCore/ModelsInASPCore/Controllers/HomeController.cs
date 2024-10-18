using Microsoft.AspNetCore.Mvc;
using ModelsInASPCore.Models;
using System.Diagnostics;

namespace ModelsInASPCore.Controllers
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
              var student = new List<StudentModel>() {
              new StudentModel{RollNo = 1,Name = "Ahmed", Gender = "Male", Standard = 10},
              new StudentModel{RollNo = 2,Name = "Ali", Gender = "Male", Standard = 9},
              new StudentModel{RollNo = 3,Name = "Alina", Gender = "Female", Standard = 8}
            };
            ViewData["MyStudents"]=student;
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
    }
}
