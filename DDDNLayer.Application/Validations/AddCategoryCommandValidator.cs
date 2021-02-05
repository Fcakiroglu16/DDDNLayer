using DDDNLayer.Application.Commands;

using System;
using System.Collections.Generic;
using System.Text;

namespace DDDNLayer.Application.Validations
{
    public class AddCategoryCommandValidator : CategoryValidator<AddCategoryCommand>
    {
        public AddCategoryCommandValidator()
        {
            ValidateName();
            ValidateType();
        }
    }
}