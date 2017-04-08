using System;

namespace Source.Models
{
    public class Address
    {
        public string City { get; protected set; }
        public string Street { get; protected set; }
        public string ZipCode { get; protected set; }

        public Address(string city, string street, string zipCode)
        {
            city.FailIfEmpty(nameof(city));
            street.FailIfEmpty(nameof(street));
            zipCode.FailIfEmpty(nameof(zipCode));            
            City = city;
            Street = street;
            ZipCode = zipCode;
        }
    }
}