using DDDNLayer.Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDNLayer.Domain.Entities
{
    public class Category : Entity, IAggregateRoot
    {
        public Category(string name, int type)
        {
            Name = name;
            Type = type;
        }

        protected Category()
        {
        }

        public string Name { get; private set; }
        public int Type { get; private set; }
    }
}