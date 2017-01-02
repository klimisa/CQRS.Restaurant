using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Restaurant.Contracts.Commands
{
    public class AssignEmployeeToLocationCommand: BaseCommand
    {
        public readonly int EmployeeId;
        public readonly int LocationId;

        public AssignEmployeeToLocationCommand(Guid id, int locationId, int employeeId)
        {
            Id = id;
            EmployeeId = employeeId;
            LocationId = locationId;
        }
    }
}
