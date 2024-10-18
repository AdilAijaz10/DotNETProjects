using Microsoft.AspNetCore.Mvc;

namespace RoutingWithoutMVC.Controllers
{
    [Route("[controller]/[action]")]

    public class HomeController : Controller
    {
        [Route("")]
        [Route("~/")]
        [Route("~/Home")]
        public IActionResult Index()
        {
            return View("~/Views/Home/Index.cshtml");
        }
        public IActionResult About()
        {
            return View();
        }
        [Route("{id?}")]
        public int Details( int? id )
        {
            return id ?? 1;
        }
    }
}