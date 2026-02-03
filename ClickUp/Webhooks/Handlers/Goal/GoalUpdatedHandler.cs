using Blackbird.Applications.Sdk.Common.Invocation;
using Blackbird.Applications.Sdk.Common.Webhooks;

namespace Apps.ClickUp.Webhooks.Handlers.Goal;

public class GoalUpdatedHandler : BaseWebhookHandler
{
    protected override string EventType => "goalUpdated";

    public GoalUpdatedHandler(InvocationContext invocationContext, [WebhookParameter] WebhookScopeRequest team) : base(invocationContext, team)
    {
    }
}