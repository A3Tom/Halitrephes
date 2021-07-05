using System.Collections.Generic;
using System.Linq;

namespace Halitrephes.Domain.ViewModels
{
    public class DynamicDataPointVM
    {
        public int Id { get; init; }
        public string Title { get; init; }
        public string Description { get; init; }

        public List<GeoLocationVM> HistoricalGeoLocations { get; init; } = new List<GeoLocationVM>();

        public GeoLocationVM CurrentGeoLocation => HistoricalGeoLocations
            .OrderByDescending(x => x.RecordedOn)
            .FirstOrDefault();
    }
}
