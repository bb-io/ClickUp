using Blackbird.Applications.Sdk.Common;
using ClickUp.Webhooks.Models.Payloads.Additional;

namespace ClickUp.Webhooks.Models.Payloads.Base;

public class ClickUpWebhookResponse
{
    [Display("History items")]
    public IEnumerable<HistoryItem>? HistoryItems { get; set; }
}