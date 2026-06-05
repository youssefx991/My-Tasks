using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Signalrtestuser.Controllers
{
    public class chatController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}
