using Microsoft.AspNetCore.SignalR;

namespace SignalrD1.Hubs
{
    public class VisitCountHub:Hub
    {
        static int visitcount = 0;
        public void increasecount()
        {
            visitcount++;
            Clients.All.SendAsync("updatevisitcount", visitcount);
        }
    }
}
