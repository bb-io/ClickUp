using Apps.ClickUp.Models.Request.Team;
using Blackbird.Applications.Sdk.Common.Webhooks;

namespace Apps.ClickUp.Webhooks.Handlers.Goal;

public class GoalUpdatedHandler : BaseWebhookHandler
{
    protected override string EventType => "goalUpdated";

    public GoalUpdatedHandler([WebhookParameter] WebhookScopeRequest team) : base(team)
    {
    }
}