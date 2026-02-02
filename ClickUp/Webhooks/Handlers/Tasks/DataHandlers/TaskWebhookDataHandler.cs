using Apps.ClickUp.DataSourceHandlers.Task;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.ClickUp.Webhooks.Handlers.Tasks.DataHandlers
{
    public class TaskWebhookDataHandler : TaskDataHandler
    {
        public TaskWebhookDataHandler(InvocationContext invocationContext, WebhookScopeRequest request) :
        base(invocationContext, request.ListId)
        {

        }
    }
}
