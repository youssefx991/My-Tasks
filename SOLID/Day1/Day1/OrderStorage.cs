using System;
using System.Collections.Generic;
using System.Text;

namespace Day1
{
    public class OrderStorage : IOrderStorage
    {
        private readonly SqlOrderStorage _storage = new SqlOrderStorage();

        public void Save(Order order) => _storage.Save(order);
    }
}
