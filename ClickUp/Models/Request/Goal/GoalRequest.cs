using Apps.ClickUp.DataSourceHandlers;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Dynamic;

namespace Apps.ClickUp.Models.Request.Goal;

public class GoalRequest
{
    [Display("Goal ID")] 
    [DataSource(typeof(GoalDataHandler))]
    public string GoalId { get; set; }
}