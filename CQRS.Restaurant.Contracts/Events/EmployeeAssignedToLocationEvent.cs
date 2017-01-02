using System;

namespace CQRS.Restaurant.Contracts.Events
{
    public class EmployeeAssignedToLocationEvent : BaseEvent
    {
        public int LocationId { get; private set; }
        public int EmployeeId { get; private set; }
        public EmployeeAssignedToLocationEvent(Guid id, int employeeId, int locationId)
        {
            Id = id;
            LocationId = locationId;
            EmployeeId = employeeId;
        }
    }
}