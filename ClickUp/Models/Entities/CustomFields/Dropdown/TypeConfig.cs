using Newtonsoft.Json;

namespace Apps.ClickUp.Models.Entities.CustomFields.Dropdown;

public class TypeConfig
{
    [JsonProperty("options")]
    public List<TypeConfigOption> Options { get; set; } = [];
}