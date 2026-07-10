namespace Apps.ClickUp.Models.Entities;

public class LocationEntity
{
    public Coordinates Location { get; set; }

    public string PlaceId { get; set; }

    public string FormattedAddress { get; set; }
}

public class Coordinates
{
    public double Lat { get; set; }

    public double Lng { get; set; }
}