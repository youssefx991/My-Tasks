using System;
using System.Collections.Generic;
using System.Text;

namespace Day1
{
    public class OrderStorage : IOrderStorage
    {
        private readonly IOrderWriter _storage;

        public OrderStorage(IOrderWriter storage)
        {
            _storage = storage;
        }

        public void Save(Order order) => _storage.Save(order);
    }
}
