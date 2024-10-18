using ASPCoreViewImports.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPCoreViewImports.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Students> student = new List<Students>() {
              new Students{Id = 1,Name = "Ahmed", Gender = "Male"},
              new Students{Id = 2,Name = "Ali", Gender = "Male"},
              new Students{Id = 3,Name = "Alina", Gender = "Female"}
            };
            ViewData["MyStudents"] = student;
            return View(student);
        }
        public IActionResult About()
        {
            List<Students> student = new List<Students>() {
              new Students{Id = 1,Name = "Ahmed", Gender = "Male"},
              new Students{Id = 2,Name = "Ali", Gender = "Male"},
              new Students{Id = 3,Name = "Alina", Gender = "Female"}
            };
            ViewData["MyStudents"] = student;
            return View(student);
        }
        public IActionResult Contact()
        {
            List<Students> student = new List<Students>() {
              new Students{Id = 1,Name = "Ahmed", Gender = "Male"},
              new Students{Id = 2,Name = "Ali", Gender = "Male"},
              new Students{Id = 3,Name = "Alina", Gender = "Female"}
            };
            ViewData["MyStudents"] = student;
            return View(student);
        }
    }
}
