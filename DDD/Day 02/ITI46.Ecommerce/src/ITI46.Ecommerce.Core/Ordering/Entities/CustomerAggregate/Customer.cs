using ITI46.Ecommerce.Core.Base;
using ITI46.Ecommerce.Core.Ordering.Enums;
using ITI46.Ecommerce.Core.Ordering.Interfaces;

namespace ITI46.Ecommerce.Core.Ordering.Entities.CustomerAggregate
{
    public class Customer : Entity<int>, IAggregateRoot
    {
        public string Name { get; private set; }

        public CustomerType Type { get; private set; }

        public Customer(int id, string name, CustomerType type)
        {
            Id = id;
            Name = name;
            Type = type;
        }
    }
}