using Blackbird.Applications.Sdk.Common;

namespace ClickUp.Webhooks.Models.Payloads.Responses;

public class GoalWebhookResponse
{
    [Display("Goal ID")]
    public string GoalId { get; set; }
}