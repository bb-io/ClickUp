using Blackbird.Applications.Sdk.Common.Invocation;
using Blackbird.Applications.Sdk.Common.Webhooks;

namespace Apps.ClickUp.Webhooks.Handlers.List;

public class ListUpdatedHandler : BaseWebhookHandler
{
    protected override string EventType => "listUpdated";

    public ListUpdatedHandler(InvocationContext invocationContext, [WebhookParameter] WebhookScopeRequest team) : base(invocationContext, team)
    {
    }
}