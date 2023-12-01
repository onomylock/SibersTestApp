using MediatR;

namespace Application.Commands.Employee
{
    public class AddEmployeeToProjectCommand : IRequest<int>
    {
        public string Email { get; set; }
        public string ProjectName { get; set; }
    }

    public class AddEmployeeToProjectCommandHandler : IRequestHandler<AddEmployeeToProjectCommand, int>
    {
        public Task<int> Handle(AddEmployeeToProjectCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
