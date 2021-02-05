using DDDDNLayer.Domain.CategoryDomain.Validations;
using FluentValidation;

namespace DDDNLayer.Domain.CategoryDomain
{
    public class AddCategoryCommand : CategoryCommand
    {
        public override bool IsValid()
        {
            ValidationResult = new AddCategoryCommandValidator().Validate(this);

            return ValidationResult.IsValid;
        }
    }
}