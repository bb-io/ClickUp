using Apps.ClickUp.DataSourceHandlers.Folder;
using Blackbird.Applications.Sdk.Common.Invocation;
using Blackbird.Applications.Sdk.Common.Webhooks;

namespace Apps.ClickUp.Webhooks.Handlers.Tasks.DataHandlers
{
    public class FolderWebhookDataHandler : FolderDataHandler
    {
        public FolderWebhookDataHandler(InvocationContext invocationContext, [WebhookParameter] WebhookScopeRequest request) :
        base(invocationContext, request.SpaceId)
        {

        }
    }
}
