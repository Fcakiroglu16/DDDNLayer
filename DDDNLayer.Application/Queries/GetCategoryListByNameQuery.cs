using DDDNLayer.Application.Queries;

using System;
using System.Collections.Generic;
using System.Text;

namespace DDNLayer.Application.Queries
{
    public class GetCategoryListByNameQuery : Query
    {
        public string Name { get; set; }
    }
}