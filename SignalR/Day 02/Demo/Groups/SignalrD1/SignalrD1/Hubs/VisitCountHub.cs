using Microsoft.AspNetCore.SignalR;

namespace SignalrD1.Hubs
{
    public class VisitCountHub:Hub
    {
        static int visitcount = 0;
        static int onlineconnection = 0;
        public void increasecount()
        {
            visitcount++;
            Clients.All.SendAsync("updatevisitcount", visitcount);
        }
        public override Task OnConnectedAsync()
        {
            onlineconnection++;
            Clients.All.SendAsync("updateonlineconnection", onlineconnection);
            return base.OnConnectedAsync();
        }
        public override Task OnDisconnectedAsync(Exception? exception)
        {
            onlineconnection--;
            Clients.All.SendAsync("updateonlineconnection", onlineconnection);
            return base.OnDisconnectedAsync(exception);
        }
    }
}
