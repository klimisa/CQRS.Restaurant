using System;
using CQRSlite.Events;

namespace CQRS.Restaurant.Contracts
{
    public class BaseEvent: IEvent
    {
        public Guid Id { get; set; }
        public int Version { get; set; }
        public DateTimeOffset TimeStamp { get; set; }
    }
}