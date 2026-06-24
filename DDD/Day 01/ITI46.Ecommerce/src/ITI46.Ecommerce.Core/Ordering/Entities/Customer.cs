using ITI46.Ecommerce.Core.Base;
using ITI46.Ecommerce.Core.Ordering.Enums;

namespace ITI46.Ecommerce.Core.Ordering.Models
{
    public class Customer : Entity<int>
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