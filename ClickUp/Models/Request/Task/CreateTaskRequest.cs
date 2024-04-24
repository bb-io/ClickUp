using Apps.ClickUp.DataSourceHandlers.Static;
using Apps.ClickUp.Models.Entities.Simple;
using Apps.ClickUp.Utils.Converters;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Dictionaries;
using Newtonsoft.Json;

namespace Apps.ClickUp.Models.Request.Task;

public class CreateTaskRequest
{
    public string Name { get; set; }
    public string? Description { get; set; }

    public IEnumerable<int>? Assignees { get; set; }

    public IEnumerable<string>? Tags { get; set; }

    public string? Status { get; set; }

    [StaticDataSource(typeof(TaskPriorityDataHandler))]
    public string? Priority { get; set; }

    [Display("Due date")]
    [JsonConverter(typeof(UnixTimestampConverter))] 
    public DateTime? DueDate { get; set; }
    
    [Display("Due date time")]
    public bool? DueDateTime { get; set; }
    
    [Display("Time estimate")]
    public int? TimeEstimate { get; set; }

    [Display("Start date")]
    [JsonConverter(typeof(UnixTimestampConverter))] 
    public DateTime? StartDate { get; set; }

    [Display("Start date time")]
    public bool? StartDateTime { get; set; }

    [Display("Notify all")]
    public bool? NotifyAll { get; set; }

    public string? Parent { get; set; }

    [Display("Links to")]
    public string? LinksTo { get; set; }

    [Display("Check required custom fields")]
    public bool? CheckRequiredCustomFields { get; set; }
}