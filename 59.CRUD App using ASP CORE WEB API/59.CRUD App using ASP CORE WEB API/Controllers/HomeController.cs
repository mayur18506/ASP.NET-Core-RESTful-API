using _59.CRUD_App_using_ASP_CORE_WEB_API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _59.CRUD_App_using_ASP_CORE_WEB_API.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
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
