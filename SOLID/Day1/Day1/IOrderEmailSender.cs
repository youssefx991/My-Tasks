using System;
using System.Collections.Generic;
using System.Text;

namespace Day1
{
    public interface IOrderEmailSender
    {
        public void SendConfirmationEmail(Order order);
    }
}
