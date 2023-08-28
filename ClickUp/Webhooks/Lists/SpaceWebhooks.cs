using Blackbird.Applications.Sdk.Common.Webhooks;
using ClickUp.Webhooks.Handlers.Space;
using ClickUp.Webhooks.Lists.Base;
using ClickUp.Webhooks.Models.Payloads.Responses;

namespace ClickUp.Webhooks.Lists;

[WebhookList]
public class SpaceWebhooks : ClickUpWebhookList
{
    [Webhook("On space created", typeof(SpaceCreatedHandler), Description = "On a new space is created")]
    public Task<WebhookResponse<SpaceWebhookResponse>> SpaceCreated(WebhookRequest request)
        => HandleRequest<SpaceWebhookResponse>(request);
    
    [Webhook("On space updated", typeof(SpaceUpdatedHandler), Description = "On a specific space is updated")]
    public Task<WebhookResponse<SpaceWebhookResponse>> SpaceUpdated(WebhookRequest request)
        => HandleRequest<SpaceWebhookResponse>(request);
    
    [Webhook("On space deleted", typeof(SpaceDeletedHandler), Description = "On a specific space is deleted")]
    public Task<WebhookResponse<SpaceWebhookResponse>> SpaceDeleted(WebhookRequest request)
        => HandleRequest<SpaceWebhookResponse>(request);
}