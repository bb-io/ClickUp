using Apps.ClickUp.Models.Entities.CustomFields;
using Apps.ClickUp.Models.Entities.CustomFields.Base;
using Blackbird.Applications.Sdk.Common;

namespace Apps.ClickUp.Models.Response.CustomField;

public class GetTaskCheckboxCustomFieldResponse : CustomFieldEntity
{
    public GetTaskCheckboxCustomFieldResponse(CheckboxCustomFieldEntity entity)
    {
        Id = entity.Id;
        Type = entity.Type;
        Name = entity.Name;
        Value = entity.Value;
    }

    [Display("Value")]
    public bool Value { get; set; }
}