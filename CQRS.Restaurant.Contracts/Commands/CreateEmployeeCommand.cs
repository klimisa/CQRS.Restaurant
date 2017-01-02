using System;

namespace CQRS.Restaurant.Contracts.Commands
{
    public class CreateEmployeeCommand: BaseCommand
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string JobTitle { get; set; }

        public CreateEmployeeCommand(Guid id, int employeeId, string firstName, string lastName, DateTime dateOfBirth, string jobTitle)
        {
            Id = id;
            EmployeeId = employeeId;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            JobTitle = jobTitle;
        }
    }
}