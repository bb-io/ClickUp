using Apps.ClickUp.Models.Entities.CustomFields.Base;
using Newtonsoft.Json;

namespace Apps.ClickUp.Models.Entities.CustomFields;

public class CheckboxCustomFieldEntity : CustomFieldEntity
{
    [JsonProperty("value")]
    public bool Value { get; set; }
}