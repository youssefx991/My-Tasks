using Lab1.Models;
using Microsoft.AspNetCore.SignalR;

namespace Lab1.Hubs
{
    public class OrderHub : Hub
    {
        public OrderContext OrderContext { get; }
        public OrderHub(OrderContext context)
        {
            OrderContext = context;
        }


        public void AddOrder(Order order)
        {
            Console.WriteLine(order == null);          // false
            Console.WriteLine(OrderContext == null);   // false
            Console.WriteLine(OrderContext?.Orders == null); // false
            Console.WriteLine(Clients == null); // false

            OrderContext?.Orders?.Add(order);
            OrderContext?.SaveChanges();
            Clients?.All.SendAsync("addorder", order);
        }
    }
}
