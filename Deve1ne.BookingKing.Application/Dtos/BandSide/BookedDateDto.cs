using Deve1ne.BookingKing.Application.Dtos.OrgSide;

namespace Deve1ne.BookingKing.Application.Dtos.BandSide;

public class BookedDateDto
{
    DateOnly Date { get; set; }
    
    List<BookerDto> PotentialBookers { get; set; }
    
    List<string> PoentialCities { get; set; }
    
    List<AlarmDto> Alarms { get; set; }
}