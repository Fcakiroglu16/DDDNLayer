using DDDNLayer.Domain.Core.Commands;
using DDDNLayer.Domain.Core.Messaging;
using FluentValidation.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DDDNLayer.Domain.Core.Mediator
{
    public class MediatorHandler : IMediatorHandler
    {
        private readonly IMediator _mediator;

        public MediatorHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public Task PublishEvent<T>(T @event) where T : Event
        {
            return _mediator.Publish(@event);
        }

        public Task<ValidationResult> SendCommand<T>(T command) where T : Command
        {
            return _mediator.Send(command);
        }
    }
}