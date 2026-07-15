using Newtonsoft.Json;

namespace Apps.ClickUp.Models.Entities.CustomFields.Label;

public class LabelTypeConfigOption
{
    [JsonProperty("id")]
    public string Id { get; set; } = string.Empty;

    [JsonProperty("label")]
    public string Label { get; set; } = string.Empty;
}