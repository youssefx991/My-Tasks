using Day3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day3.Controllers
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
