using Microsoft.AspNetCore.Mvc;

namespace Day5_46.Areas.Students.Controllers
{
    public class StdController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
