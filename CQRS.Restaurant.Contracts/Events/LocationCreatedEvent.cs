using System;

namespace CQRS.Restaurant.Contracts.Events
{
    public class LocationCreatedEvent: BaseEvent
    {
        public int LocationId { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }

        public LocationCreatedEvent(Guid id, int locationId, string streetAddress, string city, string state, string postalCode)
        {
            Id = id;
            LocationId = locationId;
            StreetAddress = streetAddress;
            City = city;
            State = state;
            PostalCode = postalCode;
        }
    }
}