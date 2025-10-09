using Apps.ClickUp.DataSourceHandlers;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Dynamic;

namespace Apps.ClickUp.Models.Request.Goal;

public class GoalRequest
{
    [Display("Team")]
    [DataSource(typeof(TeamDataHandler))]
    public string TeamId { get; set; }

    [Display("Goal ID")] 
    [DataSource(typeof(GoalDataHandler))]
    public string GoalId { get; set; }
}