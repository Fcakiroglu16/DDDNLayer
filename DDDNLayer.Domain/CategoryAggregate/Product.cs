using DDDNLayer.Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDNLayer.Domain.CategoryAggregate
{
    public class Product : Entity
    {
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public int Stock { get; private set; }
        public ProductFeature ProductFeature { get; private set; }

        public Product()
        {
        }

        public Product(string name, decimal price, int stock, int height, int width, string color)
        {
            Name = name;
            Price = price;
            Stock = stock;
            ProductFeature = new ProductFeature(height, width, color);
        }
    }
}