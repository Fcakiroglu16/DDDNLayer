using DDDNLayer.Domain.Core.Commands;
using DDDNLayer.Domain.Core.Messaging;
using DDDNLayer.Domain.Core.Models;
using DDDNLayer.Domain.Core.Queries;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DDDNLayer.Domain.Core.Mediator
{
    public interface IMediatorHandler
    {
        Task PublishEvent<T>(T @event) where T : Event;

        Task<Response> SendCommand<T>(T command) where T : Command;

        Task<Response> SendQuery<T>(T query) where T : Query;
    }
}