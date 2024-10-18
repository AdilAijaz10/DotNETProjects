using CRUDAppUsingASPCoreWebAPI.Models;
using Humanizer;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Text.Json.Serialization;

namespace CRUDAppUsingASPCoreWebAPI.Controllers
{
    public class StudentController : Controller
    {
        private string url = "https://localhost:7106/api/StudentAPI/";
        private HttpClient client = new HttpClient();

        [HttpGet]
        public IActionResult Index()
        {
            List<Student> students = new List<Student>();
            HttpResponseMessage response = client.GetAsync(url).Result;
            if (response.IsSuccessStatusCode)
            {
                string result = response.Content.ReadAsStringAsync().Result;
                var data = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Student>>(result);
                if (data != null)
                {
                    students = data;
                }
            }
            return View(students);
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(Student std)
        {
            string data = Newtonsoft.Json.JsonConvert.SerializeObject(std);
            StringContent content = new StringContent(data, Encoding.UTF8, "Application/json");
            HttpResponseMessage response = client.PostAsync(url, content).Result;
            if (response.IsSuccessStatusCode)
            {
                TempData["Insert_Message"] = "Student Added ...";
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Student std = new Student();
            HttpResponseMessage response = client.GetAsync(url + id).Result;
            if (response.IsSuccessStatusCode)
            {
                string result = response.Content.ReadAsStringAsync().Result;
                var data = Newtonsoft.Json.JsonConvert.DeserializeObject<Student>(result);
                if (data != null)
                {
                    std = data;
                }
            }
            return View(std);
        }

        [HttpPost]
        public IActionResult Edit(Student std)
        {
            string data = Newtonsoft.Json.JsonConvert.SerializeObject(std);
            StringContent content = new StringContent(data, Encoding.UTF8, "Application/json");
            HttpResponseMessage response = client.PutAsync(url +std.id, content).Result;
            if (response.IsSuccessStatusCode)
            {
                TempData["Update_Message"] = "Student Updated ...";
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            Student std = new Student();
            HttpResponseMessage response = client.GetAsync(url + id).Result;
            if (response.IsSuccessStatusCode)
            {
                string result = response.Content.ReadAsStringAsync().Result;
                var data = Newtonsoft.Json.JsonConvert.DeserializeObject<Student>(result);
                if (data != null)
                {
                    std = data;
                }
            }
            return View(std);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Student std = new Student();
            HttpResponseMessage response = client.GetAsync(url + id).Result;
            if (response.IsSuccessStatusCode)
            {
                string result = response.Content.ReadAsStringAsync().Result;
                var data = Newtonsoft.Json.JsonConvert.DeserializeObject<Student>(result);
                if (data != null)
                {
                    std = data;
                }
            }
            return View(std);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            HttpResponseMessage response = client.GetAsync(url + id).Result;
            if (response.IsSuccessStatusCode)
            {
                TempData["Delete_Message"] = "Student Deleted ...";
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
