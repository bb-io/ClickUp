using Apps.ClickUp.DataSourceHandlers.Space;
using Blackbird.Applications.Sdk.Common.Invocation;
using Blackbird.Applications.Sdk.Common.Webhooks;

namespace Apps.ClickUp.Webhooks.Handlers.Tasks.DataHandlers
{
    public class SpaceWebhookDataHandler : SpaceDataHandler
    {
        public SpaceWebhookDataHandler(InvocationContext invocationContext, WebhookScopeRequest request) :
        base(invocationContext, request.TeamId)
        {

        }
    }
}
