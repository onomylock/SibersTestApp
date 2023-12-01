using MediatR;

namespace Application.Commands.Role
{
    public class UpdateRoleCommand : IRequest<int>
    {
        public string OldRoleName { get; set; }
        public string NewRoleName { get; set;}
    }

    public class UpdateRoleCommandHandler : IRequestHandler<UpdateRoleCommand, int>
    {
        public Task<int> Handle(UpdateRoleCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
