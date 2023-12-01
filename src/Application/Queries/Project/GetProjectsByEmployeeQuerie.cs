using Application.DTOs;
using MediatR;

namespace Application.Queries.Project
{
    public class GetProjectsByEmployeeQuerie : IRequest<List<ProjectDto>>
    {
        public string Email { get; set; }
    }

    public class GetProjectsByEmployeeQuerieHandler : IRequestHandler<GetProjectsByEmployeeQuerie, List<ProjectDto>>
    {
        public Task<List<ProjectDto>> Handle(GetProjectsByEmployeeQuerie request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
