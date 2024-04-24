using Apps.ClickUp.DataSourceHandlers;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Dynamic;
using Newtonsoft.Json;

namespace Apps.ClickUp.Models.Request.Group;

public class ListGroupsQuery
{
    [JsonProperty("team_id")]
    [Display("Team ID")]
    [DataSource(typeof(TeamDataHandler))]
    public string? TeamId { get; set; }
    
    [JsonProperty("group_ids")]
    [Display("Group IDs")]
    public string? GroupIds { get; set; }
}