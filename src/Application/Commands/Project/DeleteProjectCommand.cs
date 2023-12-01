using MediatR;

namespace Application.Commands.Project
{
    public class DeleteProjectCommand : IRequest<int>
    {
        public string ProjectName { get; set; }
    }

    public class DeleteProjectCommandHandler : IRequestHandler<DeleteProjectCommand, int>
    {
        public Task<int> Handle(DeleteProjectCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
