using MediatR;

namespace Application.Queries.Role
{
    public class GetAllRolesQuerie : IRequest<List<string>>
    {
    }

    public class GetAllRolesQuerieHangler : IRequestHandler<GetAllRolesQuerie, List<string>>
    {
        public Task<List<string>> Handle(GetAllRolesQuerie request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
