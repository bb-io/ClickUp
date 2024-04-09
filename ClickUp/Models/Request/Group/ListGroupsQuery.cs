using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.ClickUp.Models.Request.Group;

public class ListGroupsQuery
{
    [JsonProperty("team_id")]
    [Display("Team ID")]
    public string? TeamId { get; set; }
    
    [JsonProperty("group_ids")]
    [Display("Group IDs")]
    public string? GroupIds { get; set; }
}