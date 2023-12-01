using MediatR;

namespace Application.Commands.Auth
{
    public class RegistrationEmployeeCommand : IRequest<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmationPassword { get; set; }
        public string Token { get; set; }
    }

    public class RegistrationEmployeeCommandHandler : IRequestHandler<RegistrationEmployeeCommand, int>
    {
        public Task<int> Handle(RegistrationEmployeeCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
