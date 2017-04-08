using System;

namespace Source.Models
{
    public class Product : Entity
    {
        public decimal Price { get; }
        public string Name { get; }

        public Product(int id, string name, decimal price) : base(id)
        {
            name.FailIfEmpty(nameof(name));
            price.FailIfLessThanZero(nameof(price));
            Name = name;
            Price = price;
        }
    }
}