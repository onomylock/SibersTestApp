using Application.DTOs;
using MediatR;

namespace Application.Queries.Employee
{
    public class GetAllEmployeesQuerie : IRequest<List<EmployeeDto>>
    {
    }

    public class GetAllEmployeesQuerieHandler : IRequestHandler<GetAllEmployeesQuerie, List<EmployeeDto>>
    {
        public Task<List<EmployeeDto>> Handle(GetAllEmployeesQuerie request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
