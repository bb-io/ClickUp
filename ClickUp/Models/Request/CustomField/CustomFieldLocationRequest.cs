namespace Apps.ClickUp.Models.Request.CustomField;

public class CustomFieldLocationRequest
{
    public LocationData Value { get; set; }

    public CustomFieldLocationRequest(CustomFieldLocationValue value)
    {
        Value = new()
        {
            FormattedAddress = value.FormattedAddress,
            Location = new()
            {
                Lat = value.Latitude,
                Lng = value.Longitude
            }
        };
    }
}

public class LocationData
{
    public Location Location { get; set; }

    public string FormattedAddress { get; set; }
}

public class Location
{
    public double Lat { get; set; }
    public double Lng { get; set; }
}