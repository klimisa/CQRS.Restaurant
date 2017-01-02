using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRS.Restaurant.Contracts.Events;
using CQRSlite.Domain;

namespace CQRS.Restaurant.Domain
{
    public class Location : AggregateRoot
    {
        public readonly int LocationId;
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }

        private readonly List<int> _employees;

        public Location(Guid id, int locationId, string streetAddress, string city, string state, string postalCode)
        {
            Id = id;
            LocationId = locationId;
            StreetAddress = streetAddress;
            City = city;
            State = state;
            PostalCode = postalCode;
            _employees = new List<int>();

            ApplyChange(new LocationCreatedEvent(id, locationId, streetAddress, city, state, postalCode));
        }

        public void AddEmployee(int employeeId)
        {
            _employees.Add(employeeId);
            ApplyChange(new EmployeeAssignedToLocationEvent(Id, LocationId, employeeId));
        }

        public void RemoveEmployee(int employeeId)
        {
            _employees.Remove(employeeId);
            ApplyChange(new EmployeeRemovedFromLocationEvent(Id, LocationId, employeeId));
        }
    }
}
