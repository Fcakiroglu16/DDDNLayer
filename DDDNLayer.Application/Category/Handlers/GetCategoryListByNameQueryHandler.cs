using DDDNLayer.Application.Category.Dtos;
using DDDNLayer.Data;
using DDDNLayer.Domain.CategoryDomain.Queries;
using DDDNLayer.Domain.Core.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DDDNLayer.Application.Category.Handlers
{
    public class GetCategoryListByNameQueryHandler : IRequestHandler<GetCategoryListByNameQuery, Response>
    {
        private readonly AppDbContext _context;

        public GetCategoryListByNameQueryHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Response> Handle(GetCategoryListByNameQuery request, CancellationToken cancellationToken)
        {
            var categories = await _context.Categories.Where(x => x.Name == request.Name).ToListAsync();

            return Response.Success(ObjectMapper.Mapper.Map<List<CategoryDto>>(categories), 200);
        }
    }
}