using Lab2MVC.Data;
using Lab2MVC.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;

namespace Lab2MVC.Hubs
{
    public class ChatHub : Hub
    {
        public ApplicationDbContext dbContext { get; }
        public UserManager<IdentityUser> UserManager { get; }

        public ChatHub(ApplicationDbContext _context, UserManager<IdentityUser> userManager)
        {
            dbContext = _context;
            UserManager = userManager;

        }

        public override async Task OnConnectedAsync()
        {
            var email = Context.User?.Identity?.Name ?? "Unknown";
            await Clients.All.SendAsync("connected", email);
            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception? exception)
        {
            var email = Context.User?.Identity?.Name ?? "Unknown";
            await Clients.All.SendAsync("disconnected", email);
            await base.OnDisconnectedAsync(exception);
        }

        public async Task CreateRoom(string roomName)
        {
            var room = new Models.Room { Name = roomName };
            dbContext.Rooms.Add(room);
            await dbContext.SaveChangesAsync();

            var email = Context.User?.Identity?.Name ?? "Unknown";
            await Clients.All.SendAsync("createroom", email, room);
        }

        public async Task DeleteRoom(int roomId)
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
                await dbContext.SaveChangesAsync();
            }
            var email = Context.User?.Identity?.Name ?? "Unknown";
            await Clients.All.SendAsync("deleteroom", email, room);
        }

        public async Task AddUserToRoom(int roomId)
        {
            var room = dbContext.Rooms.Find(roomId);
            var principal = Context.User;
            if (room == null || principal == null)
            {
                return;
            }

            var user = await UserManager.GetUserAsync(principal);

            if (user != null)
            {
                await Groups.AddToGroupAsync(Context.ConnectionId, room.Name);

                var alreadyExists = dbContext.UserRooms.Any(ur => ur.RoomId == roomId && ur.UserId == user.Id);
                if (!alreadyExists)
                {
                    dbContext.UserRooms.Add(new UserRoom { RoomId = roomId, UserId = user.Id });
                    await dbContext.SaveChangesAsync();
                }

                await Clients.Caller.SendAsync("userjoined", user.Email, room.Name);
                await Clients.OthersInGroup(room.Name).SendAsync("userjoined", user.Email, room.Name);
            }
        }

        public async Task SendPublicMessage(int roomId, string message)
        {
            var room = dbContext.Rooms.Find(roomId);
            var principal = Context.User;
            if (room == null || principal == null)
            {
                return;
            }

            var user = await UserManager.GetUserAsync(principal);

            if (user != null)
            {
                dbContext.ChatMessages.Add(new ChatMessage
                {
                    Text = message,
                    SentAt = DateTime.UtcNow,
                    RoomId = roomId,
                    SenderId = user.Id
                });
                await dbContext.SaveChangesAsync();

                await Clients.Group(room.Name).SendAsync("publicmessage", user.Email, room.Name, message);
            }
        }

        public async Task SendPrivateMessage(string receiverId, string message)
        {
            var principal = Context.User;
            if (principal == null)
            {
                return;
            }

            var sender = await UserManager.GetUserAsync(principal);
            var receiver = dbContext.Users.Find(receiverId);
            if (sender != null && receiver != null)
            {
                await Clients.User(receiver.Id).SendAsync("privatemessage", sender, message);
                dbContext.ChatMessages.Add(new ChatMessage
                {
                    Text = message,
                    SentAt = DateTime.UtcNow,
                    SenderId = sender.Id,
                    ReceiverId = receiver.Id
                });
                await dbContext.SaveChangesAsync();
            }
        }



    }
}
