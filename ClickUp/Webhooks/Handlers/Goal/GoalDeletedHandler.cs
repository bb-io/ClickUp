using Apps.ClickUp.Models.Request.Team;
using Blackbird.Applications.Sdk.Common.Webhooks;

namespace Apps.ClickUp.Webhooks.Handlers.Goal;

public class GoalDeletedHandler : BaseWebhookHandler
{
    protected override string EventType => "goalDeleted";

    public GoalDeletedHandler([WebhookParameter] TeamRequest team) : base(team)
    {
    }
}