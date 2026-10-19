using _59.CRUD_App_using_ASP_CORE_WEB_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace _59.CRUD_App_using_ASP_CORE_WEB_API.Controllers
{
    public class StudentController : Controller
    {
        private string url = "https://localhost:44315/api/StudentAPI";
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
            // Here you would typically send the data to your API endpoint
            StringContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync(url, content).Result;
            if (response.IsSuccessStatusCode)
            {
                TempData["SuccessMessage"] = "Student created successfully!";
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Student std = new Student();
            HttpResponseMessage response = client.GetAsync(url + "/" + id).Result;
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
            // Here you would typically send the data to your API endpoint
            StringContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PutAsync(url + "/" + std.id, content).Result;
            if (response.IsSuccessStatusCode)
            {
                TempData["UpdateMessage"] = "Student updated successfully!";
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            Student std = new Student();
            HttpResponseMessage response = client.GetAsync(url + "/" + id).Result;
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
            HttpResponseMessage response = client.GetAsync(url + "/" + id).Result;
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

        [HttpPost,ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
           
            HttpResponseMessage response = client.DeleteAsync(url + "/" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                TempData["DeleteMessage"] = "Student deleted successfully!";
                return RedirectToAction("Index");

            }
            return View();
        }
    }
}
