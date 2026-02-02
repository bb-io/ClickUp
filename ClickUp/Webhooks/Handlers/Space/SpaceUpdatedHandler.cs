using Apps.ClickUp.Models.Request.Team;
using Blackbird.Applications.Sdk.Common.Invocation;
using Blackbird.Applications.Sdk.Common.Webhooks;

namespace Apps.ClickUp.Webhooks.Handlers.Space;

public class SpaceUpdatedHandler : BaseWebhookHandler
{
    protected override string EventType => "spaceUpdated";

    public SpaceUpdatedHandler(InvocationContext invocationContext, [WebhookParameter] WebhookScopeRequest team) : base(invocationContext,team)
    {
    }
}