using MediatR;

namespace Application.Commands.Role
{
    public class CreateRoleCommand : IRequest<int>
    {
        string RoleName { get; set; }
    }

    public class CreateRoleCommandHandler : IRequestHandler<CreateRoleCommand, int>
    {
        public Task<int> Handle(CreateRoleCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
