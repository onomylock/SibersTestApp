using Application.DTOs;
using MediatR;

namespace Application.Commands.Auth
{
    public class AuthCommand : IRequest<AuthResponseDto>
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
    }

    public class AuthCommandHandler : IRequestHandler<AuthCommand, AuthResponseDto>
    {
        public Task<AuthResponseDto> Handle(AuthCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
