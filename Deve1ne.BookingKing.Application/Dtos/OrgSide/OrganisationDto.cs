namespace Deve1ne.BookingKing.Application.Dtos.OrgSide;

public class OrganisationDto : BookerDto
{
    public List<OrganizerDto> Organizers { get; set; }
    
    public string Website { get; set; }
    
    public List<string> AvailablePlaces { get; set; }
}