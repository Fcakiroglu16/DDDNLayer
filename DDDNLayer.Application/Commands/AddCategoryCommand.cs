using DDDNLayer.Application.Validations;
using FluentValidation;

namespace DDDNLayer.Application.Commands
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