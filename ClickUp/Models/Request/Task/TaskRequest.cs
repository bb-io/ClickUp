using Blackbird.Applications.Sdk.Common;

namespace Apps.ClickUp.Models.Request.Task;

public class TaskRequest
{
    [Display("Task ID")]
    public string TaskId { get; set; }
}