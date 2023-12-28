using Apps.ClickUp.Webhooks.Models.Payloads.Additional;
using Blackbird.Applications.Sdk.Common;

namespace Apps.ClickUp.Webhooks.Models.Payloads.Base;

public class ClickUpWebhookResponse
{
    [Display("History items")]
    public IEnumerable<HistoryItem>? HistoryItems { get; set; }
}