using Apps.ClickUp.Models.Entities.CustomFields.Base;
using Newtonsoft.Json;

namespace Apps.ClickUp.Models.Entities.CustomFields.Label;

public class LabelCustomFieldEntity : CustomFieldEntity
{
    [JsonProperty("type_config")] 
    public LabelTypeConfig TypeConfig { get; set; } = null!;
    
    [JsonProperty("value")]
    public List<string> Value { get; set; } = [];
}