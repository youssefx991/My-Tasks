using Microsoft.AspNetCore.SignalR;

namespace Lab2MVC.Hubs
{
    public class ChatHub : Hub
    {
        public override Task OnConnectedAsync()
        {
            var email = Context.User?.Identity?.Name ?? "Unknown";
            Clients.All.SendAsync("connected", $"{email} has joined the chat.");
            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception? exception)
        {
            var email = Context.User?.Identity?.Name ?? "Unknown";
            Clients.All.SendAsync("disconnected", $"{email} has left the chat.");
            return base.OnDisconnectedAsync(exception);
        }
    }
}
