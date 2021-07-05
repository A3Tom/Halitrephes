namespace Halitrephes.Domain.ViewModels
{
    public class StaticDataPointVM
    {
        public int Id { get; init; }
        public string Title { get; init; }
        public string Description { get; init; }

        public GeoLocationVM GeoLocation { get; init; }
    }
}
