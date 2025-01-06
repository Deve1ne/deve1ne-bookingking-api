namespace Deve1ne.BookingKing.Application.Dtos.BandSide;

public class UserDto
{
    Guid UserId { get; set; }
    string UserName { get; set; }
    string Email { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
    string Password { get; set; }
    List<BandDto> Bands { get; set; }
    
}