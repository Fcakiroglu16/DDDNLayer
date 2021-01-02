using DDDNLayer.Domain.Commands.Category.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDNLayer.Domain.Commands.Category
{
    public class AddCategoryCommand : CategoryCommand
    {
        public AddCategoryCommand(string name, int type)
        {
            Name = name;
            Type = type;
        }

        public override bool IsValid()
        {
            return new AddCategoryCommandValidator().Validate(this).IsValid;
        }
    }
}