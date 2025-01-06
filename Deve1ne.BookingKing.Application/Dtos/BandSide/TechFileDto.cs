using System.Reflection.Metadata;

namespace Deve1ne.BookingKing.Application.Dtos.BandSide;

public class TechFileDto
{
    Blob  TechFile { get; set; }
    
    string FileName { get; set; }
    
    string FileExtension { get; set; }
    
    string Language { get; set; }
    
    string Description { get; set; }
    
    BandDto Band { get; set; }
    
    string Type { get; set; }
    
}