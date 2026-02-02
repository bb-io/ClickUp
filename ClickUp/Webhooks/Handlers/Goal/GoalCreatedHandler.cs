using Apps.ClickUp.Models.Request.Team;
using Blackbird.Applications.Sdk.Common.Invocation;
using Blackbird.Applications.Sdk.Common.Webhooks;

namespace Apps.ClickUp.Webhooks.Handlers.Goal;

public class GoalCreatedHandler : BaseWebhookHandler
{
    protected override string EventType => "goalCreated";

    public GoalCreatedHandler(InvocationContext invocationContext, [WebhookParameter] WebhookScopeRequest team) : base(invocationContext,team)
    {
    }
}