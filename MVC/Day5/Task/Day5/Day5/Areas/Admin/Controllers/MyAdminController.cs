using Microsoft.AspNetCore.Mvc;

namespace Day5.Areas.Admin.Controllers
{
    public class MyAdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
