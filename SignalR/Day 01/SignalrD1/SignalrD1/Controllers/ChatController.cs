using Microsoft.AspNetCore.Mvc;
using SignalrD1.Models;

namespace SignalrD1.Controllers
{
    public class ChatController : Controller
    {
        public ChatController(chatContext db)
        {
            Db = db;
        }

        public chatContext Db { get; }

        public IActionResult Index()
        {
            return View(Db.Messages.ToList());
        }
    }
}
