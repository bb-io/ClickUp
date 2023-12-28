using Blackbird.Applications.Sdk.Common;

namespace Apps.ClickUp.Models.Request.Goal;

public class GoalRequest
{
    [Display("Goal ID")]
    public string GoalId { get; set; }
}