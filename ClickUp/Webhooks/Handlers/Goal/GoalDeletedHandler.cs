using Blackbird.Applications.Sdk.Common.Webhooks;
using ClickUp.Models.Request.Team;

namespace ClickUp.Webhooks.Handlers.Goal;

public class GoalDeletedHandler : BaseWebhookHandler
{
    protected override string EventType => "goalDeleted";

    public GoalDeletedHandler([WebhookParameter] TeamRequest team) : base(team)
    {
    }
}