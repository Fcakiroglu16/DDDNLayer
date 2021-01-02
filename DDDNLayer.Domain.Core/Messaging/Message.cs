using System;
using System.Collections.Generic;
using System.Text;

namespace DDDNLayer.Domain.Core.Messaging
{
    public abstract class Message
    {
        public string MessageType { get; protected set; }
        public Guid AggregateId { get; protected set; }
    }
}