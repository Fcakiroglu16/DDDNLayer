using DDDNLayer.Domain.CategoryDomain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDDNLayer.Domain.CategoryDomain.Validations
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