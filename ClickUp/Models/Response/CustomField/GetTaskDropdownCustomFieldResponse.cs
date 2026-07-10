using Apps.ClickUp.Models.Entities.CustomFields.Base;
using Apps.ClickUp.Models.Entities.CustomFields.Dropdown;
using Blackbird.Applications.Sdk.Common;

namespace Apps.ClickUp.Models.Response.CustomField;

public class GetTaskDropdownCustomFieldResponse : CustomFieldEntity
{
    public GetTaskDropdownCustomFieldResponse(DropdownCustomFieldEntity entity)
    {
        Id = entity.Id;
        Name = entity.Name;
        Type = entity.Type;
        Index = entity.Value;

        var option = entity.TypeConfig.Options.FirstOrDefault(x => x.OrderIndex == Index);
        DropdownValueId = option?.Id ?? string.Empty;
        Value = option?.Name ?? string.Empty;
    }
    
    [Display("Dropdown value")]
    public string Value { get; set; }

    [Display("Dropdown value ID")]
    public string DropdownValueId { get; set; }

    [Display("Dropdown order index")]
    public int Index { get; set; }
}