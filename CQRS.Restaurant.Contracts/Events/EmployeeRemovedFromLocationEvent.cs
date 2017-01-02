using System;

namespace CQRS.Restaurant.Contracts.Events
{
    public class EmployeeRemovedFromLocationEvent : BaseEvent
    {
        public int LocationId { get; private set; }
        public int EmployeeId { get; private set; }

        public EmployeeRemovedFromLocationEvent(Guid id, int locationId, int employeeId)
        {
            Id = id;
            LocationId = locationId;
            EmployeeId = employeeId;
        }
    }
}