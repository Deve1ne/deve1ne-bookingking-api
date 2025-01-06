namespace Deve1ne.BookingKing.Application.Dtos.BandSide;

public class TourDto
{
    List<BookedDateDto> Dates { get; set; }

    List<BandDto> Bands { get; set; }
}