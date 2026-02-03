using Blackbird.Applications.Sdk.Common.Invocation;
using Blackbird.Applications.Sdk.Common.Webhooks;

namespace Apps.ClickUp.Webhooks.Handlers.Tasks;

public class TaskTimeTrackedUpdatedHandler : BaseWebhookHandler
{
    protected override string EventType => "taskTimeTrackedUpdated";

    public TaskTimeTrackedUpdatedHandler(InvocationContext invocationContext, [WebhookParameter] WebhookScopeRequest team) : base(invocationContext, team)
    {
    }
}