using System;
using System.Collections.Generic;
using System.Text;

namespace Day1
{
    public interface IOrderReader
    {
        public IEnumerable<Order> GetAll();
    }
}
