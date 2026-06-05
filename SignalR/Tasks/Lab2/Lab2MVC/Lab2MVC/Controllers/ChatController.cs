using Microsoft.AspNetCore.Mvc;

namespace Lab2MVC.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
