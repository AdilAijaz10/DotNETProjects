using Microsoft.AspNetCore.Mvc;

namespace HeaderAndFooterTemplate.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {


            //ViewData
            ViewData["data1"] = "Adil";
            ViewData["data2"] = 095;
            ViewData["data3"] = DateTime.Now.ToLongDateString();
            string[] arr = { "Adil", "Ramish", "Zahir" };
            ViewData["data4"] = arr;
            ViewData["data5"] = new List<string>()
            {
                "cricket","football","hockey"
            };




            //ViewBag
            ViewBag.VBdata1 = "Adil";
            ViewBag.VBdata2 = 095;
            ViewBag.VBdata3 = DateTime.Now.ToShortDateString();
            string[] arr1 = { "Adil", "Ramish", "Zahir" };
            ViewBag.VBdata4 = arr1;
            ViewBag.VBdata5 = new List<string>()
            {
                "cricket","football","hockey"
            };
            ViewData["myname"] = "my name is Adil, controlled by ViewData, Viewed by ViewBag";
            


            //TempDataConcept
            TempData["TDdataA"] = "TempData";
            ViewData["VDdataA"] = "ViewData";
            ViewBag.VBdataA = "ViewBag";
            TempData.Keep("TDdataA");

            return View();
        }
        public IActionResult About()
        {
            //TempData restored on About page
            TempData.Keep("TDdataA");
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}
