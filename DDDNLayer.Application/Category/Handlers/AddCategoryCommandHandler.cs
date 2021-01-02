using DDDNLayer.Data;
using DDDNLayer.Domain.CategoryDomain;
using DDDNLayer.Domain.Core.Commands;
using FluentValidation.Results;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace DDDNLayer.Application.Category.Handlers
{
    public class AddCategoryCommandHandler : CommandHandler, IRequestHandler<AddCategoryCommand, ValidationResult>
    {
        private readonly AppDbContext _context;

        public AddCategoryCommandHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<ValidationResult> Handle(AddCategoryCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                return request.ValidationResult;
            }

            var category = new DDDNLayer.Domain.Entities.Category(request.Name, request.Type);

            //Event fırlat

            _context.Categories.Add(category);
            await _context.CommitAsync();

            return request.ValidationResult;
        }
    }
}