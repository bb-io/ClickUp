using Blackbird.Applications.Sdk.Common;
using ClickUp.Webhooks.Models.Payloads.Base;

namespace ClickUp.Webhooks.Models.Payloads.Responses;

public class TaskWebhookResponse : ClickUpWebhookResponse
{
    [Display("Task ID")]
    public string TaskId { get; set; }
}