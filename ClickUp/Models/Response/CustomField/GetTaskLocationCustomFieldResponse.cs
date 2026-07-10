using Apps.ClickUp.Models.Entities.CustomFields;
using Apps.ClickUp.Models.Entities.CustomFields.Base;
using Blackbird.Applications.Sdk.Common;

namespace Apps.ClickUp.Models.Response.CustomField;

public class GetTaskLocationCustomFieldResponse : CustomFieldEntity
{
    public GetTaskLocationCustomFieldResponse(LocationCustomFieldEntity entity)
    {
        Id = entity.Id;
        Name = entity.Name;
        Type = entity.Type;
        Latitude = entity.Value?.Location.Lat;
        Longitude = entity.Value?.Location.Lng;
        PlaceId = entity.Value?.PlaceId;
        FormattedAddress = entity.Value?.FormattedAddress;
    }
    
    [Display("Latitude")] 
    public double? Latitude { get; set; }

    [Display("Longitude")] 
    public double? Longitude { get; set; }

    [Display("Place ID")] 
    public string? PlaceId { get; set; }

    [Display("Formatted address")] 
    public string? FormattedAddress { get; set; }
}