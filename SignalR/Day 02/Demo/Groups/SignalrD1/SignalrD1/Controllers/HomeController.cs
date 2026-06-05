using Microsoft.AspNetCore.Mvc;
using SignalrD1.Models;
using System.Diagnostics;

namespace SignalrD1.Controllers
{
    public class HomeController : Controller
    {
       // static int count = 0;
        public IActionResult Index()
        {
           // count++;
            //return View(count);
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
