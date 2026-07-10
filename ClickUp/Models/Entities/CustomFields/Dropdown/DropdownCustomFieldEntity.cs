using Apps.ClickUp.Models.Entities.CustomFields.Base;
using Newtonsoft.Json;

namespace Apps.ClickUp.Models.Entities.CustomFields.Dropdown;

public class DropdownCustomFieldEntity : CustomFieldEntity
{
    [JsonProperty("type_config")] 
    public TypeConfig TypeConfig { get; set; } = null!;

    [JsonProperty("value")]
    public int Value { get; set; }
}