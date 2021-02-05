using System;
using System.Collections.Generic;
using System.Text;

namespace DDDNLayer.Application.Commands
{
    public abstract class CategoryCommand : Command
    {
        public string Name { get; protected set; }
        public int Type { get; protected set; }
    }
}