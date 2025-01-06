using Deve1ne.BookingKing.Application.Dtos.BandSide;
using MediatR;

namespace Deve1ne.BookingKing.Application.Features.Users.Commands;

public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, UserDto>
{
    public Task<UserDto> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}