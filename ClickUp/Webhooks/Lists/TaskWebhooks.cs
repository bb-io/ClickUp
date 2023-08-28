using Blackbird.Applications.Sdk.Common.Webhooks;
using ClickUp.Webhooks.Handlers.Tasks;
using ClickUp.Webhooks.Lists.Base;
using ClickUp.Webhooks.Models.Payloads.Responses;

namespace ClickUp.Webhooks.Lists;

[WebhookList]
public class TaskWebhooks : ClickUpWebhookList
{
    [Webhook("On task created", typeof(TaskCreatedHandler),
        Description = "On a new task is created")]
    public Task<WebhookResponse<TaskWebhookResponse>> TaskCreated(WebhookRequest request)
        => HandleRequest<TaskWebhookResponse>(request);

    [Webhook("On task updated", typeof(TaskUpdatedHandler), Description = "On a specific task is updated")]
    public Task<WebhookResponse<TaskWebhookResponse>> TaskUpdated(WebhookRequest request)
        => HandleRequest<TaskWebhookResponse>(request);

    [Webhook("On task deleted", typeof(TaskDeletedHandler), Description = "On a specific task is deleted")]
    public Task<WebhookResponse<TaskWebhookResponse>> TaskDeleted(WebhookRequest request)
        => HandleRequest<TaskWebhookResponse>(request);

    [Webhook("On task priority updated", typeof(TaskPriorityUpdatedHandler),
        Description = "On a specific task's Priority is set or updated")]
    public Task<WebhookResponse<TaskWebhookResponse>> TaskPriorityUpdated(WebhookRequest request)
        => HandleRequest<TaskWebhookResponse>(request);

    [Webhook("On task status updated", typeof(TaskStatusUpdatedHandler),
        Description = "On a specific task's Status is updated")]
    public Task<WebhookResponse<TaskWebhookResponse>> TaskStatusUpdated(WebhookRequest request)
        => HandleRequest<TaskWebhookResponse>(request);

    [Webhook("On task assignee updated", typeof(TaskAssigneeUpdatedHandler),
        Description = "On a specific task's assignee is set or updated")]
    public Task<WebhookResponse<TaskWebhookResponse>> TaskAssigneeUpdated(WebhookRequest request)
        => HandleRequest<TaskWebhookResponse>(request);

    [Webhook("On task due date updated", typeof(TaskDueDateUpdatedHandler),
        Description = "On a specific task's due date is set or updated")]
    public Task<WebhookResponse<TaskWebhookResponse>> TaskDueDateUpdated(WebhookRequest request)
        => HandleRequest<TaskWebhookResponse>(request);

    [Webhook("On task tag updated", typeof(TaskTagUpdatedHandler), Description = "On a specific task's tag updated")]
    public Task<WebhookResponse<TaskWebhookResponse>> TaskTagUpdated(WebhookRequest request)
        => HandleRequest<TaskWebhookResponse>(request);

    [Webhook("On task moved", typeof(TaskMovedHandler), Description = "On a specific task moved")]
    public Task<WebhookResponse<TaskWebhookResponse>> TaskMoved(WebhookRequest request)
        => HandleRequest<TaskWebhookResponse>(request);

    [Webhook("On task comment posted", typeof(TaskCommentPostedHandler),
        Description = "On a specific task's comment posted")]
    public Task<WebhookResponse<TaskWebhookResponse>> TaskCommentPosted(WebhookRequest request)
        => HandleRequest<TaskWebhookResponse>(request);

    [Webhook("On task comment updated", typeof(TaskCommentUpdatedHandler),
        Description = "On a specific task's comment updated")]
    public Task<WebhookResponse<TaskWebhookResponse>> TaskCommentUpdated(WebhookRequest request)
        => HandleRequest<TaskWebhookResponse>(request);

    [Webhook("On task time estimate updated", typeof(TaskTimeEstimateUpdatedHandler),
        Description = "On a specific task's time estimate updated")]
    public Task<WebhookResponse<TaskWebhookResponse>> TaskTimeEstimateUpdated(WebhookRequest request)
        => HandleRequest<TaskWebhookResponse>(request);

    [Webhook("On task time tracked updated", typeof(TaskTimeTrackedUpdatedHandler),
        Description = "On a specific task's time tracked updated")]
    public Task<WebhookResponse<TaskWebhookResponse>> TaskTimeTrackedUpdated(WebhookRequest request)
        => HandleRequest<TaskWebhookResponse>(request);
}