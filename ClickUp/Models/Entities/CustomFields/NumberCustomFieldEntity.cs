using Apps.ClickUp.Models.Entities.CustomFields.Base;

namespace Apps.ClickUp.Models.Entities.CustomFields;

public class NumberCustomFieldEntity : CustomFieldEntity
{
    public long Value { get; set; }
}