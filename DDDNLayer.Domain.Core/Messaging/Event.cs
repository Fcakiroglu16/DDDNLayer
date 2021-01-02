using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDNLayer.Domain.Core.Messaging
{
    public abstract class Event : Message, INotification
    {
        public DateTime TimeSpan { get; set; }
    }
}