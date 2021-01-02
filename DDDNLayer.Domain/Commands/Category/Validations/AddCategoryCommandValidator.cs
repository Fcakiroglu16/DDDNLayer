using System;
using System.Collections.Generic;
using System.Text;

namespace DDDNLayer.Domain.Commands.Category.Validations
{
    internal class AddCategoryCommandValidator : CategoryValidator<AddCategoryCommand>
    {
        public AddCategoryCommandValidator()
        {
            ValidateName();
            ValidateType();
        }
    }
}