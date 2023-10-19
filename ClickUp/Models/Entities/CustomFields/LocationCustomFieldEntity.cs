using ClickUp.Models.Entities.CustomFields.Base;

namespace ClickUp.Models.Entities.CustomFields;

public class LocationCustomFieldEntity : CustomFieldEntity
{
    public LocationEntity Value { get; set; }
}