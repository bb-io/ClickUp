using Apps.ClickUp.DataSourceHandlers;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Dynamic;
using Newtonsoft.Json;

namespace Apps.ClickUp.Models.Request.Group;

public class ListGroupsQuery
{
   [JsonProperty("group_ids")]
    [Display("Group IDs")]
    public string? GroupIds { get; set; }
}