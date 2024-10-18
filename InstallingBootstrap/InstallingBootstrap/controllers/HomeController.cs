using Microsoft.AspNetCore.Mvc;

namespace InstallingBootstrap.controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
