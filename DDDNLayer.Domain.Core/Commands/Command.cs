using FluentValidation.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDNLayer.Domain.Core.Commands
{
    public abstract class Command : IRequest<ValidationResult>
    {
        public DateTime Timestamp { get; private set; }
        public ValidationResult ValidationResult { get; set; }

        public Command()
        {
            Timestamp = DateTime.Now;
        }

        public virtual bool IsValid()
        {
            return ValidationResult.IsValid;
        }
    }
}