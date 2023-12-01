using Application.DTOs;
using MediatR;

namespace Application.Commands.Employee
{
    public class UpdateEmployeeCommand : IRequest<int>
    {
        public EmployeeDto employee { get; set; }
    }

    public class UpdateEmployeeCommandHandler : IRequestHandler<UpdateEmployeeCommand, int>
    {
        public Task<int> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
