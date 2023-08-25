using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Dynamic;
using ClickUp.DataSourceHandlers.EnumHandlers;
using ClickUp.Models.Entities.Simple;

namespace ClickUp.Models.Request.Task;

public class CreateTaskRequest
{
    public string Name { get; set; }
    public string? Description { get; set; }

    public IEnumerable<int>? Assignees { get; set; }

    public IEnumerable<string>? Tags { get; set; }

    public string? Status { get; set; }

    [DataSource(typeof(TaskPriorityDataHandler))]
    public string? Priority { get; set; }

    [Display("Due date")]
    public long? DueDate { get; set; }
    
    [Display("Due date time")]

    public bool? DueDateTime { get; set; }
    
    [Display("Time estimate")]

    public int? TimeEstimate { get; set; }

    [Display("Start date")]
    public long? StartDate { get; set; }

    [Display("Start date time")]
    public bool? StartDateTime { get; set; }

    [Display("Notify all")]
    public bool? NotifyAll { get; set; }

    public string? Parent { get; set; }

    [Display("Links to")]
    public string? LinksTo { get; set; }

    [Display("Check required custom fields")]
    public bool? CheckRequiredCustomFields { get; set; }

    [Display("Custom fields")]
    public IEnumerable<SimpleCustomField>? CustomFields { get; set; }
}