using Apps.ClickUp.Webhooks.Handlers.List;
using Apps.ClickUp.Webhooks.Lists.Base;
using Apps.ClickUp.Webhooks.Models.Payloads.Responses;
using Blackbird.Applications.Sdk.Common.Webhooks;

namespace Apps.ClickUp.Webhooks.Lists;

[WebhookList]
public class ListWebhooks : ClickUpWebhookList
{
    [Webhook("On list created", typeof(ListCreatedHandler), Description = "On a new list is created")]
    public Task<WebhookResponse<ListWebhookResponse>> ListCreated(WebhookRequest request)
        => HandleRequest<ListWebhookResponse>(request);
    
    [Webhook("On list updated", typeof(ListUpdatedHandler), Description = "On a specific list is updated")]
    public Task<WebhookResponse<ListWebhookResponse>> ListUpdated(WebhookRequest request)
        => HandleRequest<ListWebhookResponse>(request);
    
    [Webhook("On list deleted", typeof(ListDeletedHandler), Description = "On a specific list is deleted")]
    public Task<WebhookResponse<ListWebhookResponse>> ListDeleted(WebhookRequest request)
        => HandleRequest<ListWebhookResponse>(request);
}