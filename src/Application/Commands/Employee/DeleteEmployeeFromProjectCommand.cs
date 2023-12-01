using MediatR;

namespace Application.Commands.Employee
{
    public class DeleteEmployeeFromProjectCommand : IRequest<int>
    {
        public string Email { get; set; }
        public string ProjectName { get; set; }
    }

    public class DeleteEmployeeFromProjectCommandHandler : IRequestHandler<DeleteEmployeeFromProjectCommand, int>
    {
        public Task<int> Handle(DeleteEmployeeFromProjectCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
