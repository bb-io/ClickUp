using Blackbird.Applications.Sdk.Common.Webhooks;
using ClickUp.Models.Request.Team;

namespace ClickUp.Webhooks.Handlers.Goal;

public class GoalCreatedHandler : BaseWebhookHandler
{
    protected override string EventType => "goalCreated";

    public GoalCreatedHandler([WebhookParameter] TeamRequest team) : base(team)
    {
    }
}