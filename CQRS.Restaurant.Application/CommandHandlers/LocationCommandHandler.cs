using CQRS.Restaurant.Contracts.Commands;
using CQRS.Restaurant.Domain;
using CQRSlite.Commands;
using CQRSlite.Domain;

namespace CQRS.Restaurant.Application.CommandHandlers
{
    public class LocationCommandHandler: ICommandHandler<CreateLocationCommand>,
                                      ICommandHandler<AssignEmployeeToLocationCommand>,
                                      ICommandHandler<RemoveEmployeeFromLocationCommand>
    {
        private readonly ISession _session;

        public LocationCommandHandler(ISession session)
        {
            _session = session;
        }

        public void Handle(CreateLocationCommand command)
        {
            var location = new Location(command.Id, command.LocationId, command.StreetAddress, command.City, command.State, command.PostalCode);
            _session.Add(location);
            _session.Commit();
        }

        public void Handle(AssignEmployeeToLocationCommand command)
        {
            var location = _session.Get<Location>(command.Id);
            location.AddEmployee(command.EmployeeId);
            _session.Commit();
        }

        public void Handle(RemoveEmployeeFromLocationCommand command)
        {
            var location = _session.Get<Location>(command.Id);
            location.RemoveEmployee(command.EmployeeId);
            _session.Commit();
        }
    }
}