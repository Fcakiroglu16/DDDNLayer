using DDDNLayer.Domain.Core.Queries;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDNLayer.Domain.CategoryDomain.Queries
{
    public class GetCategoryListByNameQuery : Query
    {
        public string Name { get; set; }
    }
}