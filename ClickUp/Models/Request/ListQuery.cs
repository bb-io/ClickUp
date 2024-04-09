using Newtonsoft.Json;

namespace Apps.ClickUp.Models.Request;

public class ListQuery
{
    [JsonProperty("archived")]
    public bool? Archived { get; set; }
}