using DDDNLayer.Data;
using DDDNLayer.Domain.Commands.Category;
using DDDNLayer.Domain.Core.Commands;
using FluentValidation.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DDDNLayer.Application.Handlers.Category
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

            await _context.CommitAsync();

            return request.ValidationResult;
        }
    }
}