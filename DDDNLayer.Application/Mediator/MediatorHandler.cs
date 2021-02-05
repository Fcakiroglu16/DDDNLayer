using DDDNLayer.Application.Commands;
using DDDNLayer.Application.Queries;
using DDDNLayer.Domain.Core.Messaging;
using DDDNLayer.Domain.Core.Models;

using FluentValidation.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DDDNLayer.Application.Mediator
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

        public Task<Response> SendCommand<T>(T command) where T : Command
        {
            return _mediator.Send(command);
        }

        public async Task<Response> SendQuery<T>(T query) where T : Query
        {
            return await _mediator.Send(query);
        }
    }
}