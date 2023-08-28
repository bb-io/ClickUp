using Blackbird.Applications.Sdk.Common.Webhooks;
using ClickUp.Models.Request.Team;

namespace ClickUp.Webhooks.Handlers.Goal;

public class GoalUpdatedHandler : BaseWebhookHandler
{
    protected override string EventType => "goalUpdated";

    public GoalUpdatedHandler([WebhookParameter] TeamRequest team) : base(team)
    {
    }
}