using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SignalrD1.Hubs;
using SignalrD1.Models;

namespace SignalrD1.Controllers
{
    public class ChatController : Controller
    {
        public ChatController(chatContext db ,IHubContext<ChatHub> _chathub)
        {
            Db = db;
            _Chathub = _chathub;
        }

        public chatContext Db { get; }
        public IHubContext<ChatHub> _Chathub { get; }

        public IActionResult Index()
        {
            return View(Db.Messages.ToList());
        }

        public IActionResult display()
        {
            _Chathub.Clients.All.SendAsync("newmessage", new Message() { Name = "controller", Messagebody = "test from controller" });
            return View();
        }
    }
}
