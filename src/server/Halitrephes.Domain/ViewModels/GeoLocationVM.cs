using System;

namespace Halitrephes.Domain.ViewModels
{
    public class GeoLocationVM
    {
        public double Latitude { get; init; }
        public double Longitude { get; init; }
        public DateTimeOffset? RecordedOn { get; init; } 
    }
}
