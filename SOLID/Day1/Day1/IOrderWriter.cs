using System;
using System.Collections.Generic;
using System.Text;

namespace Day1
{
    public interface IOrderWriter
    {
        public void Save(Order order);
    }
}
