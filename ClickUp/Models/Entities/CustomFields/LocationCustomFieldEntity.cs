using Apps.ClickUp.Models.Entities.CustomFields.Base;

namespace Apps.ClickUp.Models.Entities.CustomFields;

public class LocationCustomFieldEntity : CustomFieldEntity
{
    public LocationEntity Value { get; set; }
}