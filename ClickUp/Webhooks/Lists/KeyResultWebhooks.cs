using Apps.ClickUp.Webhooks.Handlers.KeyResult;
using Apps.ClickUp.Webhooks.Lists.Base;
using Apps.ClickUp.Webhooks.Models.Payloads.Responses;
using Blackbird.Applications.Sdk.Common.Webhooks;

namespace Apps.ClickUp.Webhooks.Lists;

[WebhookList]
public class KeyResultWebhooks : ClickUpWebhookList
{
    [Webhook("On key result created", typeof(KeyResultCreatedHandler), Description = "On a new key result is created")]
    public Task<WebhookResponse<KeyResultWebhookResponse>> KeyResultCreated(WebhookRequest request)
        => HandleRequest<KeyResultWebhookResponse>(request);
    
    [Webhook("On key result updated", typeof(KeyResultUpdatedHandler), Description = "On a specific key result is updated")]
    public Task<WebhookResponse<KeyResultWebhookResponse>> KeyResultUpdated(WebhookRequest request)
        => HandleRequest<KeyResultWebhookResponse>(request);
    
    [Webhook("On key result deleted", typeof(KeyResultDeletedHandler), Description = "On a specific key result is deleted")]
    public Task<WebhookResponse<KeyResultWebhookResponse>> KeyResultDeleted(WebhookRequest request)
        => HandleRequest<KeyResultWebhookResponse>(request);
}