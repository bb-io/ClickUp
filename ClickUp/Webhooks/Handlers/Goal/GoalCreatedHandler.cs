using Apps.ClickUp.Models.Request.Team;
using Blackbird.Applications.Sdk.Common.Webhooks;

namespace Apps.ClickUp.Webhooks.Handlers.Goal;

public class GoalCreatedHandler : BaseWebhookHandler
{
    protected override string EventType => "goalCreated";

    public GoalCreatedHandler([WebhookParameter] TeamRequest team) : base(team)
    {
    }
}