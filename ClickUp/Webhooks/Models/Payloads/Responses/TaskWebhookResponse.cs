using Apps.ClickUp.Webhooks.Models.Payloads.Base;
using Blackbird.Applications.Sdk.Common;

namespace Apps.ClickUp.Webhooks.Models.Payloads.Responses;

public class TaskWebhookResponse : ClickUpWebhookResponse
{
    [Display("Task ID")]
    public string TaskId { get; set; }
}