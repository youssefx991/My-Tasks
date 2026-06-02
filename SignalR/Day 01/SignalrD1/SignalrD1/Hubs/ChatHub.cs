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
        //public void sendmessage(string name, string message)
        //{
        //    Clients.Others.SendAsync("newmessage", name, message);

        //    //save message in db 
        //    //Db.Messages.Add(new Message() { Name=name, Messagebody=message});
        //    //Db.SaveChanges();

        //    //return message;
        //}
        public void sendmessage(Message mess)
        {
            Clients.All.SendAsync("newmessage",mess);

            
            Db.Messages.Add(mess);
            Db.SaveChanges();

           // return message;
        }
    }
}
