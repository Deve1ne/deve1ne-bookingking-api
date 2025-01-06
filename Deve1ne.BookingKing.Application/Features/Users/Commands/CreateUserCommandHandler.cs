using Deve1ne.BookingKing.Application.Dtos.BandSide;
using MediatR;

namespace Deve1ne.BookingKing.Application.Features.Users.Commands;

public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, UserDto>
{
    public Task<UserDto> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}