using Day4.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day4.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult ShowDetails(User user)
        {
            ViewBag.user = user;
            return View();
        }
    }
}
