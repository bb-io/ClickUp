using Blackbird.Applications.Sdk.Common;

namespace ClickUp.Webhooks.Models.Payloads.Task;

public class TaskWebhookResponse
{
    [Display("Task ID")]
    public string TaskId { get; set; }
    
    [Display("History items")]
    public IEnumerable<HistoryItem> HistoryItems { get; set; }
}