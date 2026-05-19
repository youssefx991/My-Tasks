using System;
using System.Collections.Generic;
using System.Text;

namespace Day1
{
    public interface IOrderStorage
    {
        public void Save(Order order);
    }
}
