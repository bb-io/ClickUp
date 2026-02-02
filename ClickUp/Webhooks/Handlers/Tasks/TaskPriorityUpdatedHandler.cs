using Apps.ClickUp.Models.Request.Team;
using Blackbird.Applications.Sdk.Common.Invocation;
using Blackbird.Applications.Sdk.Common.Webhooks;

namespace Apps.ClickUp.Webhooks.Handlers.Tasks;

public class TaskPriorityUpdatedHandler : BaseWebhookHandler
{
    protected override string EventType => "taskPriorityUpdated";

    public TaskPriorityUpdatedHandler(InvocationContext invocationContext, [WebhookParameter] WebhookScopeRequest team) : base(invocationContext,team)
    {
    }
}