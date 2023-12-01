using MediatR;

namespace Application.Commands.Role
{
    public class DeleteRoleCommand : IRequest<int>
    {
        public string RoleName { get; set; }
    }

    public class DeleteRoleCommandHandler : IRequestHandler<DeleteRoleCommand, int>
    {
        public Task<int> Handle(DeleteRoleCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
