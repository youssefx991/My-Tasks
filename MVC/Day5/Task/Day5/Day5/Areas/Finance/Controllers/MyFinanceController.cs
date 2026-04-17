using Microsoft.AspNetCore.Mvc;

namespace Day5.Areas.Finance.Controllers
{
    public class MyFinanceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
