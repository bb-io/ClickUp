using Blackbird.Applications.Sdk.Common.Invocation;
using Blackbird.Applications.Sdk.Common.Webhooks;

namespace Apps.ClickUp.Webhooks.Handlers.Tasks;

public class TaskCreatedHandler : BaseWebhookHandler
{
    protected override string EventType => "taskCreated";

    public TaskCreatedHandler(InvocationContext invocationContext, [WebhookParameter] WebhookScopeRequest team) : base(invocationContext, team)
    {
    }
}