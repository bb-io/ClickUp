using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Apps.ClickUp.Models.Response.Task;

public class TaskCustomFieldsResponse
{
    [JsonProperty("custom_fields")]
    public JArray CustomFields { get; set; }
}