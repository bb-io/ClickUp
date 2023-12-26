using Apps.ClickUp.Webhooks.Handlers.Space;
using Apps.ClickUp.Webhooks.Lists.Base;
using Apps.ClickUp.Webhooks.Models.Payloads.Responses;
using Blackbird.Applications.Sdk.Common.Webhooks;

namespace Apps.ClickUp.Webhooks.Lists;

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