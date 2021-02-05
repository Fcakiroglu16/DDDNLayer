using DDDNLayer.Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDNLayer.Domain.CategoryAggregate
{
    public class Category : Entity, IAggregateRoot
    {
        public string Name { get; private set; }
        public int Type { get; private set; }

        private readonly List<Product> _products;

        public IReadOnlyCollection<Product> Products => _products.AsReadOnly();

        public Category(string name, int type)
        {
            Name = name;
            Type = type;
        }

        public void AddProduct(string name, decimal price, int stock, int height, int width, string color)
        {
            _products.Add(new Product(name, price, stock, height, width, color));
        }

        protected Category()
        {
            _products = new List<Product>();
        }
    }
}