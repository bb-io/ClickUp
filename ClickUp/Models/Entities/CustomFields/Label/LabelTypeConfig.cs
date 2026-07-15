using Newtonsoft.Json;

namespace Apps.ClickUp.Models.Entities.CustomFields.Label;

public class LabelTypeConfig
{
    [JsonProperty("options")]
    public List<LabelTypeConfigOption> Options { get; set; } = [];
}