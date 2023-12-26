using Apps.ClickUp.Webhooks.Handlers.Goal;
using Apps.ClickUp.Webhooks.Lists.Base;
using Apps.ClickUp.Webhooks.Models.Payloads.Responses;
using Blackbird.Applications.Sdk.Common.Webhooks;

namespace Apps.ClickUp.Webhooks.Lists;

[WebhookList]
public class GoalWebhooks : ClickUpWebhookList
{
    [Webhook("On goal created", typeof(GoalCreatedHandler), Description = "On a new goal is created")]
    public Task<WebhookResponse<GoalWebhookResponse>> GoalCreated(WebhookRequest request)
        => HandleRequest<GoalWebhookResponse>(request);
    
    [Webhook("On goal updated", typeof(GoalUpdatedHandler), Description = "On a specific goal is updated")]
    public Task<WebhookResponse<GoalWebhookResponse>> GoalUpdated(WebhookRequest request)
        => HandleRequest<GoalWebhookResponse>(request);
    
    [Webhook("On goal deleted", typeof(GoalDeletedHandler), Description = "On a specific goal is deleted")]
    public Task<WebhookResponse<GoalWebhookResponse>> GoalDeleted(WebhookRequest request)
        => HandleRequest<GoalWebhookResponse>(request);
}