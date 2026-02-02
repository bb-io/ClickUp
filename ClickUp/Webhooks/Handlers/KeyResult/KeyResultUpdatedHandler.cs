using Blackbird.Applications.Sdk.Common.Invocation;
using Blackbird.Applications.Sdk.Common.Webhooks;

namespace Apps.ClickUp.Webhooks.Handlers.KeyResult;

public class KeyResultUpdatedHandler : BaseWebhookHandler
{
    protected override string EventType => "keyResultUpdated";

    public KeyResultUpdatedHandler(InvocationContext invocationContext, [WebhookParameter] WebhookScopeRequest team) : base(invocationContext, team)
    {
    }
}