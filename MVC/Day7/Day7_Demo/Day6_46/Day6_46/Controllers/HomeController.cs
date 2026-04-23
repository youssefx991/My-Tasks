using Day6_46.Models;
using Microsoft.AspNetCore.Mvc;
using System.Configuration;
using System.Diagnostics;

namespace Day6_46.Controllers
{
    public class HomeController : Controller
    {
        //Configuration configuration = new Configuartion();

        public IConfiguration Configuration { get; }
        public IWebHostEnvironment Env { get; }

        //Home Class request service of type IConfiguration from DI Container,
        // request service of type IWebHostEnvironment from DI Container,
        //Runtime check DI Container for service of type IConfiguration, if found create obj of tyepe IConfiguration & inject it into Home class constructor
        public HomeController(IConfiguration configuration, IWebHostEnvironment env) 
        {
            Configuration = configuration;
            Env = env;
        }

        public IActionResult Index()
        {
            ViewBag.MyConfigValue = Configuration["myKey"];
            ViewBag.MyEnvVar = Env.EnvironmentName;

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
