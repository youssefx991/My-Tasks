using Lab2MVC.Data;
using Microsoft.AspNetCore.SignalR;
using System.Runtime.InteropServices;

namespace Lab2MVC.Hubs
{
    public class ChatHub : Hub
    {
        public ApplicationDbContext dbContext { get; }
        public ChatHub(ApplicationDbContext _context)
        {
            dbContext = _context;

        }

        public override Task OnConnectedAsync()
        {
            var email = Context.User?.Identity?.Name ?? "Unknown";
            Clients.All.SendAsync("connected", email);
            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception? exception)
        {
            var email = Context.User?.Identity?.Name ?? "Unknown";
            Clients.All.SendAsync("disconnected", email);
            return base.OnDisconnectedAsync(exception);
        }

        public void CreateRoom(string roomName)
        {
            var room = new Models.Room { Name = roomName };
            dbContext.Rooms.Add(room);
            dbContext.SaveChanges();

            var email = Context.User?.Identity?.Name ?? "Unknown";
            Clients.All.SendAsync("createroom", email, room);
        }

        public void DeleteRoom(int roomId)
        {
            var room = dbContext.Rooms.Find(roomId);
            if (room != null)
            {
                // delete all messages in the room
                foreach (var message in dbContext.ChatMessages.Where(m => m.RoomId == roomId))
                {
                    dbContext.ChatMessages.Remove(message);
                }
                dbContext.Rooms.Remove(room);
                dbContext.SaveChanges();
            }
            var email = Context.User?.Identity?.Name ?? "Unknown";
            Clients.All.SendAsync("deleteroom", email, room);
        }

    }
}
