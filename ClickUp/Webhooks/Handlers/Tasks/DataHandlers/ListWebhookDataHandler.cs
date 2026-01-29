using Apps.ClickUp.DataSourceHandlers.List;
using Blackbird.Applications.Sdk.Common.Invocation;
using Blackbird.Applications.Sdk.Common.Webhooks;

namespace Apps.ClickUp.Webhooks.Handlers.Tasks.DataHandlers
{
    internal class ListWebhookDataHandler : ListDataHandler
    {
        public ListWebhookDataHandler(InvocationContext invocationContext,WebhookScopeRequest request) :
        base(invocationContext, request.FolderId)
        {

        }
    }
}
