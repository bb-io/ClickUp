using Apps.ClickUp.DataSourceHandlers.Task;
using Apps.ClickUp.Models.Request.Task;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.ClickUp.Webhooks.Handlers.Tasks.DataHandlers
{
    public class TaskWebhookDataHandler : TaskDataHandler
    {
        public TaskWebhookDataHandler(InvocationContext invocationContext, [ActionParameter] WebhookScopeRequest request) :
        base(invocationContext, request.ListId)
        {

        }
    }
}
