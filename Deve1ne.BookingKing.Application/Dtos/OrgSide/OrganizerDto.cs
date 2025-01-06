namespace Deve1ne.BookingKing.Application.Dtos.OrgSide;

public class OrganizerDto : BookerDto
{
    public string LastName { get; set; }
    
    public string FirstName { get; set; }
    
    public List<string> AvailablePlaces { get; set; }
}