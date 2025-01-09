using Apps.ClickUp.DataSourceHandlers.EnumHandlers;
using Apps.ClickUp.Models.Entities.Simple;
using Apps.ClickUp.Utils.Converters;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Dynamic;
using Newtonsoft.Json;

namespace Apps.ClickUp.Models.Request.Task;

public class UpdateTaskRequest
{
    public string? Name { get; set; }
    public string? Description { get; set; }

    public IEnumerable<int>? Assignees { get; set; }

    public string? Status { get; set; }

    [DataSource(typeof(TaskPriorityDataHandler))]
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

    public string? Parent { get; set; }

    [Display("Custom fields")]
    public IEnumerable<SimpleCustomField>? CustomFields { get; set; }
}