using Application.DTOs;
using MediatR;

namespace Application.Commands.Project
{
    public class AddProjectCommand : IRequest<int>
    {        
        public ProjectDto Project { get; set; }
    }

    public class AddProjectCommandHandler : IRequestHandler<AddProjectCommand, int>
    {
        public Task<int> Handle(AddProjectCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
