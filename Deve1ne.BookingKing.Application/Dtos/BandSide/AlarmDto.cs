using Deve1ne.BookingKing.Application.Dtos.OrgSide;

namespace Deve1ne.BookingKing.Application.Dtos.BandSide;

public class AlarmDto
{
    int Stage { get; set; }
    
    List<TemplateDto> Templates { get; set; }
    
    BookerDto Booker { get; set; }
    
    List<DateOnly> Dates { get; set; }
    
    
}