using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDNLayer.Domain.Commands.Category.Validations
{
    public abstract class CategoryValidator<T> : AbstractValidator<T> where T : CategoryCommand
    {
        protected void ValidateName()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required").Length(4, 20).WithMessage("Name must have between 4 and 20");
        }

        protected void ValidateType()
        {
            RuleFor(x => x.Type).InclusiveBetween(1, 10).WithMessage("Type must have  between 1 and 10");
        }
    }
}