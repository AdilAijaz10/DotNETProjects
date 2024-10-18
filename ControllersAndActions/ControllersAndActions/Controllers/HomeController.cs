using Microsoft.AspNetCore.Mvc;

namespace ControllersAndActions.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(); //*Important Point*: IActionResult is implemented by many classes like ViewResult, PartialViewResult, JsonResult etc
        }
        public String Display()
        {
            return "Adil Aijaz"; //*Important Point*: IActionResult is implemented by many classes like ViewResult, PartialViewResult, JsonResult etc
        }
        public int DisplayId(int id)
        {
            return id; //*Important Point*: IActionResult is implemented by many classes like ViewResult, PartialViewResult, JsonResult etc
        }
    }
}
