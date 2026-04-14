using Day3_46.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Day3_46.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult sendData()
        {

            ViewData["msg"] = "Hello View Data";

            ViewData["BookNames"] = new List<string>() { "C#", "DB", "MVC" };


            ViewBag.newMsg = "Hello View Bag";

            ViewBag.newBookNames = new List<string>() { ".Net", "EF", "SQL" };


            ViewData["test"] = "This is a test message";
            ViewBag.testtt = "This is a test message,,,,,,,,,,,,,,";

            return View();
        }

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
