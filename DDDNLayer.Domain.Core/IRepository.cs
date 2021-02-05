using System;
using System.Collections.Generic;
using System.Text;

namespace DDDNLayer.Domain.Core
{
    public interface IRepository<T> where T : IAggregateRoot
    {
    }
}