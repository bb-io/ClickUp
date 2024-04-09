using Blackbird.Applications.Sdk.Common;

namespace Apps.ClickUp.Webhooks.Models.Payloads.Responses;

public class KeyResultWebhookResponse : GoalWebhookResponse
{
    [Display("Key result ID")]
    public string KeyResultId { get; set; }
}