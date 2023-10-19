using ClickUp.Models.Entities.CustomFields.Base;

namespace ClickUp.Models.Entities.CustomFields;

public class NumberCustomFieldEntity : CustomFieldEntity
{
    public long Value { get; set; }
}