using Newtonsoft.Json;

namespace ClickUp.Models.Request;

public class ListQuery
{
    [JsonProperty("archived")]
    public bool? Archived { get; set; }
}