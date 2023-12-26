using Blackbird.Applications.Sdk.Common;

namespace Apps.ClickUp.Models.Request.CustomField;

public class CustomFieldLocationValue
{
    public double Latitude { get; set; }
    
    public double Longitude { get; set; }
    
    [Display("Formatted address")]
    public string FormattedAddress { get; set; }
}