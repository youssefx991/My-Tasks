using Lab2MVC.Data;
using Lab2MVC.Models;
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

        public void AddUserToRoom(int roomId)
        {
            var room = dbContext.Rooms.Find(roomId);
            var email = Context.User?.Identity?.Name ?? "Unknown";
            var user = dbContext.Users.FirstOrDefault(u => u.Email == email);

            if (room != null && user != null)
            {
                var alreadyExists = dbContext.UserRooms.Any(ur => ur.RoomId == roomId && ur.UserId == user.Id);
                if (!alreadyExists)
                {
                    Groups.AddToGroupAsync(Context.ConnectionId, room.Name);
                    Clients.OthersInGroup(room.Name).SendAsync("userjoined", user, room);
                    dbContext.UserRooms.Add(new UserRoom { RoomId = roomId, UserId = user.Id });
                    dbContext.SaveChanges();
                }
            }
        }

        public void SendPublicMessage(int roomId, string message)
        {
            var room = dbContext.Rooms.Find(roomId);
            var email = Context.User?.Identity?.Name ?? "Unknown";
            var user = dbContext.Users.FirstOrDefault(u => u.Email == email);

            Clients.Group(room.Name).SendAsync("publicmessage", user.Email, room.Name, message);
            dbContext.ChatMessages.Add(new ChatMessage
            {
                Text = message,
                SentAt = DateTime.UtcNow,
                RoomId = roomId,
                SenderId = user.Id
            });
            dbContext.SaveChanges();
        }

        public void SendPrivateMessage(string receiverId, string message)
        {
            var email = Context.User?.Identity?.Name ?? "Unknown";
            var sender = dbContext.Users.FirstOrDefault(u => u.Email == email);
            var receiver = dbContext.Users.Find(receiverId);
            if (sender != null && receiver != null)
            {
                Clients.User(receiver.Id).SendAsync("privatemessage", sender, message);
                dbContext.ChatMessages.Add(new ChatMessage
                {
                    Text = message,
                    SentAt = DateTime.UtcNow,
                    SenderId = sender.Id,
                    ReceiverId = receiver.Id
                });
                dbContext.SaveChanges();
            }
        }



    }
}
