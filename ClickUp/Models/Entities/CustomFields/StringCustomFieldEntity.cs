using ClickUp.Models.Entities.CustomFields.Base;

namespace ClickUp.Models.Entities.CustomFields;

public class StringCustomFieldEntity : CustomFieldEntity
{
    public string Value { get; set; }
}