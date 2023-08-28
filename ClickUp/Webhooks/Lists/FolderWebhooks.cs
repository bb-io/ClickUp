using Blackbird.Applications.Sdk.Common.Webhooks;
using ClickUp.Webhooks.Handlers.Folder;
using ClickUp.Webhooks.Lists.Base;
using ClickUp.Webhooks.Models.Payloads.Responses;

namespace ClickUp.Webhooks.Lists;

[WebhookList]
public class FolderWebhooks : ClickUpWebhookList
{
    [Webhook("On folder created", typeof(FolderCreatedHandler), Description = "On a new folder is created")]
    public Task<WebhookResponse<FolderWebhookResponse>> FolderCreated(WebhookRequest request)
        => HandleRequest<FolderWebhookResponse>(request);
    
    [Webhook("On folder updated", typeof(FolderUpdatedHandler), Description = "On a specific folder is updated")]
    public Task<WebhookResponse<FolderWebhookResponse>> FolderUpdated(WebhookRequest request)
        => HandleRequest<FolderWebhookResponse>(request);
    
    [Webhook("On folder deleted", typeof(FolderDeletedHandler), Description = "On a specific folder is deleted")]
    public Task<WebhookResponse<FolderWebhookResponse>> FolderDeleted(WebhookRequest request)
        => HandleRequest<FolderWebhookResponse>(request);
}