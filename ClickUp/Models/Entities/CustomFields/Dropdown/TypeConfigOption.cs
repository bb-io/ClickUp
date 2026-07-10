using Newtonsoft.Json;

namespace Apps.ClickUp.Models.Entities.CustomFields.Dropdown;

public class TypeConfigOption
{
    [JsonProperty("name")]
    public string Name { get; set; } = string.Empty;

    [JsonProperty("orderindex")]
    public int OrderIndex { get; set; }
}