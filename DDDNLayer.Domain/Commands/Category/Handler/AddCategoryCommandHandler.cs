using DDDNLayer.Domain.Core.Commands;
using FluentValidation.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DDDNLayer.Domain.Commands.Category.Handler
{
    internal class AddCategoryCommandHandler : CommandHandler, IRequestHandler<AddCategoryCommand, ValidationResult>
    {
        public Task<ValidationResult> Handle(AddCategoryCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}