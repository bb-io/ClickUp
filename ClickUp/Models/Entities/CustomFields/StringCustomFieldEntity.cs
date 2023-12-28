using Apps.ClickUp.Models.Entities.CustomFields.Base;

namespace Apps.ClickUp.Models.Entities.CustomFields;

public class StringCustomFieldEntity : CustomFieldEntity
{
    public string Value { get; set; }
}