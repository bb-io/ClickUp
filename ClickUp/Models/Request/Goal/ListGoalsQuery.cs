using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.ClickUp.Models.Request.Goal;

public class ListGoalsQuery
{
    [JsonProperty("include_completed")]
    [Display("Include completed")]
    public bool? IncludeCompleted { get; set; }
}