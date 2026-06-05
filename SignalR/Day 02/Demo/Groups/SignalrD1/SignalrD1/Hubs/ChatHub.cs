using Microsoft.AspNetCore.SignalR;
using SignalrD1.Models;

namespace SignalrD1.Hubs
{
    public class ChatHub:Hub
    {
        public ChatHub(chatContext db)
        {
            Db = db;
        }

        public chatContext Db { get; }
     
        public void sendmessage(Message mess)
        {
            Clients.All.SendAsync("newmessage",mess);
            Db.Messages.Add(mess);
            Db.SaveChanges();
        }
        public void join(string groupname ,string name)
        {
            Groups.AddToGroupAsync(Context.ConnectionId, groupname);
            Clients.OthersInGroup(groupname).SendAsync("newmember", name, groupname);
        }

        public void sendToGroup(string name , string groupname ,string message)
        {
            //save db
            Clients.Group(groupname).SendAsync("newgroupmessage",name, groupname, message);
        }

        public override Task OnConnectedAsync()
        {
            string conid = Context.ConnectionId;
            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception? exception)
        {
            return base.OnDisconnectedAsync(exception);
        }
    }
}
