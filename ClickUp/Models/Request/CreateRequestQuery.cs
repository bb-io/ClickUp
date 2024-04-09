using Apps.ClickUp.DataSourceHandlers;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Dynamic;
using Newtonsoft.Json;

namespace Apps.ClickUp.Models.Request;

public class CreateRequestQuery
{
    [Display("Custom Task IDs")]
    [JsonProperty("custom_task_ids")]
    public bool? CustomTaskIds { get; set; }
    
    [Display("Team ID")]
    [JsonProperty("team_id")]
    [DataSource(typeof(TeamDataHandler))]
    public string? TeamId { get; set; }
}