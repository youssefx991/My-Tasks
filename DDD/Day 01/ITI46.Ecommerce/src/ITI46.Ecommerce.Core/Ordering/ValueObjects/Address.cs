using ITI46.Ecommerce.Core.Base;

namespace ITI46.Ecommerce.Core.Ordering.ValueObjects
{
    public class Address : ValueObject
    {
        public string Building { get; private set; }

        public string Street { get; private set; }

        public string District { get; private set; }

        public string City { get; private set; }

        public string Country { get; private set; }

        public Address(string building, string street, string district, string city, string country)
        {
            Building = building;
            Street = street;
            District = district;
            City = city;
            Country = country;
        }

        public override bool Equals(object? obj)
        {
            if (obj is not Address other)
            {
                return false;
            }

            return Building == other.Building &&
                   Street == other.Street &&
                   District == other.District &&
                   City == other.City &&
                   Country == other.Country;
        }

        override public int GetHashCode()
        {
            return HashCode.Combine(Building, Street, District, City, Country);
        }
    }
}