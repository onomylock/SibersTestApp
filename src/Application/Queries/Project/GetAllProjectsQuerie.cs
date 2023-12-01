using Application.DTOs;
using MediatR;

namespace Application.Queries.Project
{
    public class GetAllProjectsQuerie : IRequest<List<ProjectDto>>
    {
    }

    public class GetAllProjectsQuerieHandler : IRequestHandler<GetAllProjectsQuerie, List<ProjectDto>>
    {
        public Task<List<ProjectDto>> Handle(GetAllProjectsQuerie request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
