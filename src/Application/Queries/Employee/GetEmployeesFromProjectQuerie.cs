using Application.DTOs;
using MediatR;

namespace Application.Queries.Employee
{
    public class GetEmployeesFromProjectQuerie : IRequest<List<EmployeeDto>>
    {
        public string ProjectName { get; set; }
    }

    public class GetEmployeesFromProjectQuerieHandler : IRequestHandler<GetEmployeesFromProjectQuerie, List<EmployeeDto>>
    {
        public Task<List<EmployeeDto>> Handle(GetEmployeesFromProjectQuerie request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
