using Deve1ne.BookingKing.Application.Dtos.BandSide;
using Deve1ne.BookingKing.Application.Features.Users.Commands;
using MediatR;

namespace Deve1ne.BookingKing.Application.Features.Users.Requests;

public class GetUserQueryHandler : IRequestHandler<CreateUserCommand, UserDto>
{
    public Task<UserDto> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}