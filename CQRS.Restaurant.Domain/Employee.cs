using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRS.Restaurant.Contracts.Events;
using CQRSlite.Domain;

namespace CQRS.Restaurant.Domain
{
    public class Employee : AggregateRoot
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string JobTitle { get; set; }


        public Employee(Guid id, int employeeId, string firstName, string lastName, DateTime dateOfBirth, string jobTitle)
        {
            Id = id;
            EmployeeId = employeeId;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            JobTitle = jobTitle;

            ApplyChange(new EmployeeCreatedEvent(id, employeeId, firstName, lastName, dateOfBirth, jobTitle));
        }
    }
}

