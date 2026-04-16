using Microsoft.AspNetCore.Mvc;

namespace Day5_46.Areas.Teachers.Controllers
{
    public class TechController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
