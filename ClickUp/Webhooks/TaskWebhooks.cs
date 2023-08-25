using Blackbird.Applications.Sdk.Common.Webhooks;
using ClickUp.Constants;
using ClickUp.Webhooks.Handlers.Tasks;
using ClickUp.Webhooks.Models.Payloads.Task;
using Newtonsoft.Json;

namespace ClickUp.Webhooks;

[WebhookList]
public class TaskWebhooks
{
    #region Webhooks

    [Webhook("On task created", typeof(TaskCreatedHandler),
        Description = "On a new task is created")]
    public Task<WebhookResponse<TaskWebhookResponse>> TaskCreated(WebhookRequest request)
        => HandleRequest(request);

    [Webhook("On task updated", typeof(TaskUpdatedHandler), Description = "On a specific task is updated.")]
    public Task<WebhookResponse<TaskWebhookResponse>> TaskUpdated(WebhookRequest request)
        => HandleRequest(request);

    [Webhook("On task deleted", typeof(TaskDeletedHandler), Description = "On a specific task is deleted.")]
    public Task<WebhookResponse<TaskWebhookResponse>> TaskDeleted(WebhookRequest request)
        => HandleRequest(request);

    [Webhook("On task priority updated", typeof(TaskPriorityUpdatedHandler), Description = "On a specific task's Priority is set or updated.")]
    public Task<WebhookResponse<TaskWebhookResponse>> TaskPriorityUpdated(WebhookRequest request)
        => HandleRequest(request);

    [Webhook("On task status updated", typeof(TaskStatusUpdatedHandler), Description = "On a specific task's Status is updated.")]
    public Task<WebhookResponse<TaskWebhookResponse>> TaskStatusUpdated(WebhookRequest request)
        => HandleRequest(request);

    [Webhook("On task assignee updated", typeof(TaskAssigneeUpdatedHandler), Description = "On a specific task's assignee is set or updated.")]
    public Task<WebhookResponse<TaskWebhookResponse>> TaskAssigneeUpdated(WebhookRequest request)
        => HandleRequest(request);

    [Webhook("On task due date updated", typeof(TaskDueDateUpdatedHandler), Description = "On a specific task's due date is set or updated.")]
    public Task<WebhookResponse<TaskWebhookResponse>> TaskDueDateUpdated(WebhookRequest request)
        => HandleRequest(request);

    #endregion

    #region Utils

    private Task<WebhookResponse<TaskWebhookResponse>> HandleRequest(WebhookRequest request)
    {
        var data = JsonConvert.DeserializeObject<TaskWebhookResponse>(request.Body.ToString(), JsonConfig.Settings);
        return Task.FromResult(new WebhookResponse<TaskWebhookResponse>
        {
            HttpResponseMessage = null,
            Result = data
        });
    }

    #endregion
}