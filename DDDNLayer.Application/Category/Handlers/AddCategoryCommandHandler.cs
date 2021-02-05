using DDDNLayer.Application.Category.Dtos;
using DDDNLayer.Data;
using DDDNLayer.Domain.CategoryDomain;
using DDDNLayer.Domain.Core.Commands;
using DDDNLayer.Domain.Core.Models;
using FluentValidation.Results;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DDDNLayer.Application.Category.Handlers
{
    public class AddCategoryCommandHandler : IRequestHandler<AddCategoryCommand, Response>
    {
        private readonly AppDbContext _context;

        public AddCategoryCommandHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Response> Handle(AddCategoryCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                var errors = request.ValidationResult.Errors.ToList().Select(x => x.ErrorMessage).ToList();

                var errorDto = new ErrorDto(errors, true);

                return Response.UnSuccess(errorDto, 400);
            }

            var category = _context.Categories.Add(new Domain.CategoryAggregate.Category(request.Name, request.Type));
            await _context.CommitAsync();

            var newCategoryDto = ObjectMapper.Mapper.Map<CategoryDto>(category);

            return Response.Success(newCategoryDto, 200);
        }
    }
}