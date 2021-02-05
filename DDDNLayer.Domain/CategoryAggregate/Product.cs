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
    }
}