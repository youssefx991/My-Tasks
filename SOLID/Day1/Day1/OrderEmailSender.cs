using System;
using System.Collections.Generic;
using System.Text;

namespace Day1
{
    public class OrderEmailSender : IOrderNotifier, IOrderEmailSender
    {
        private readonly SmtpEmailSender _emailer = new SmtpEmailSender();

        public void SendConfirmationEmail(Order order)
        {
            _emailer.Send(order.CustomerEmail, $"Order {order.Id} Confirmed", "...");
        }
    }
}
