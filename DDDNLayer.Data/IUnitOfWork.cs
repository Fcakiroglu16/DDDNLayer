using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DDDNLayer.Data
{
    public interface IUnitOfWork
    {
        Task<Boolean> CommitAsync();
    }
}