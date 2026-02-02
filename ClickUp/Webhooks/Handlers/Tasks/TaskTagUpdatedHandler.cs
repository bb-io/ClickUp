using Blackbird.Applications.Sdk.Common.Invocation;
using Blackbird.Applications.Sdk.Common.Webhooks;

namespace Apps.ClickUp.Webhooks.Handlers.Tasks;

public class TaskTagUpdatedHandler : BaseWebhookHandler
{
    protected override string EventType => "taskTagUpdated";

    public TaskTagUpdatedHandler(InvocationContext invocationContext, [WebhookParameter] WebhookScopeRequest team) : base(invocationContext, team)
    {
    }
}