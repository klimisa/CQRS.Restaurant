using CQRS.Restaurant.Contracts.Commands;
using CQRS.Restaurant.Domain;
using CQRSlite.Commands;
using CQRSlite.Domain;

namespace CQRS.Restaurant.Application.CommandHandlers
{
    public class EmployeeCommandHandler: ICommandHandler<CreateEmployeeCommand>
    {
        private readonly ISession _session;

        public EmployeeCommandHandler(ISession session)
        {
            _session = session;
        }

        public void Handle(CreateEmployeeCommand command)
        {
            var employee = new Employee(command.Id, command.EmployeeId, command.FirstName, command.LastName, command.DateOfBirth, command.JobTitle);
            _session.Add(employee);
            _session.Commit();
        }
    }
}
