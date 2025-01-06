using System.Reflection.Metadata;

namespace Deve1ne.BookingKing.Application.Dtos.BandSide;

public class BandDto
{
    List<TourDto> Tours { get; set; }
    
    List<string> GenericBandInfos { get; set; }
    
    List<TechFileDto> TechFiles {get;set;}
}