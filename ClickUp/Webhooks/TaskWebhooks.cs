using Blackbird.Applications.Sdk.Common.Webhooks;
using ClickUp.Responses;
using ClickUp.Webhooks.Handlers;
using ClickUp.Webhooks.Payloads;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskResponse = ClickUp.Webhooks.Models.TaskResponse;

namespace ClickUp.Webhooks
{
    [WebhookList]
    public class TaskWebhooks
    {
        private WebhookResponse<TaskResponse> HandleRequest(WebhookRequest request)
        {
            var data = JsonConvert.DeserializeObject<TaskPayload>(request.Body.ToString());
            return new WebhookResponse<TaskResponse> { HttpResponseMessage = null, Result = TaskResponse.FromTaskPayload(data) };
        }

        [Webhook("On task created", typeof(TaskCreatedHandler), Description = "This webhook is triggered when a new task is created.")]
        public async Task<WebhookResponse<TaskResponse>> TaskCreated(WebhookRequest request)
        {
            return HandleRequest(request);
        }

        [Webhook("On task updated", typeof(TaskUpdatedHandler), Description = "This webhook is triggered when a task is updated.")]
        public async Task<WebhookResponse<TaskResponse>> TaskUpdated(WebhookRequest request)
        {
            return HandleRequest(request);
        }

        [Webhook("On task deleted", typeof(TaskDeletedHandler), Description = "This webhook is triggered when a task is deleted.")]
        public async Task<WebhookResponse<TaskResponse>> TaskDeleted(WebhookRequest request)
        {
            return HandleRequest(request);
        }

        [Webhook("On task priority updated", typeof(TaskPriorityUpdatedHandler), Description = "This webhook is triggered when a task's Priority is set or updated.")]
        public async Task<WebhookResponse<TaskResponse>> TaskPriorityUpdated(WebhookRequest request)
        {
            return HandleRequest(request);
        }

        [Webhook("On task status updated", typeof(TaskStatusUpdatedHandler), Description = "This webhook is triggered when a task's Status is updated.")]
        public async Task<WebhookResponse<TaskResponse>> TaskStatusUpdated(WebhookRequest request)
        {
            return HandleRequest(request);
        }

        [Webhook("On task assignee updated", typeof(TaskAssigneeUpdatedHandler), Description = "This webhook is triggered when a task's assignee is set or updated.")]
        public async Task<WebhookResponse<TaskResponse>> TaskAssigneeUpdated(WebhookRequest request)
        {
            return HandleRequest(request);
        }

        [Webhook("On task due date updated", typeof(TaskDueDateUpdatedHandler), Description = "This webhook is triggered when a task's due date is set or updated.")]
        public async Task<WebhookResponse<TaskResponse>> TaskDueDateUpdated(WebhookRequest request)
        {
            return HandleRequest(request);
        }
    }
}
