using Microsoft.AspNetCore.SignalR;
using Signalrtestuser.Models;

namespace Signalrtestuser.Hubs
{
    public class ChatHub:Hub
    {
        public ChatHub(ITIContext db)
        {
            Db = db;
        }

        public ITIContext Db { get; }

        public void sendmesage(string sender , string rec ,string message)
        {
            string userid = Db.Users.FirstOrDefault(n => n.UserName.ToLower() == rec.ToLower()).Id;
            Clients.User(userid).SendAsync("newmessage", sender, message);
        }
        public override Task OnConnectedAsync()
        {
            var c = Context;
            return base.OnConnectedAsync();
        }
    }
}

