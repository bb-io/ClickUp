using Newtonsoft.Json;

namespace Apps.ClickUp.Models.Entities.CustomFields.Dropdown;

public class DropdownTypeConfig
{
    [JsonProperty("options")]
    public List<DropdownTypeConfigOption> Options { get; set; } = [];
}