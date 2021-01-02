using DDDNLayer.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDNLayer.Domain.Commands.Category
{
    public abstract class CategoryCommand : Command
    {
        public string Name { get; protected set; }
        public int Type { get; protected set; }
    }
}