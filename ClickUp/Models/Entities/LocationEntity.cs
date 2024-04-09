using Blackbird.Applications.Sdk.Common;

namespace Apps.ClickUp.Models.Entities;

public class LocationEntity
{
    public Coordinates Location { get; set; }

    [Display("Place ID")] public string PlaceId { get; set; }

    [Display("Formatted address")] public string FormattedAddress { get; set; }
}

public class Coordinates
{
    [Display("Latitude")] public double Lat { get; set; }

    [Display("Longitude")] public double Lng { get; set; }
}