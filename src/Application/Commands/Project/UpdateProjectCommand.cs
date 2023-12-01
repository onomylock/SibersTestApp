using Application.DTOs;
using MediatR;

namespace Application.Commands.Project
{
    public class UpdateProjectCommand : IRequest<int>
    {
        public ProjectDto Project { get; set; }
    }

    public class UpdateProjectCommandHandler : IRequestHandler<UpdateProjectCommand, int>
    {
        public Task<int> Handle(UpdateProjectCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
