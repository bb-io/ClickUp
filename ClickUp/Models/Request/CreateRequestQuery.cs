using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.ClickUp.Models.Request;

public class CreateRequestQuery
{
    [Display("Custom Task IDs")]
    [JsonProperty("custom_task_ids")]
    public bool? CustomTaskIds { get; set; }
}