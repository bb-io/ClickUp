using Apps.ClickUp.DataSourceHandlers.Static;
using Apps.ClickUp.Utils.Converters;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Dictionaries;
using Newtonsoft.Json;

namespace Apps.ClickUp.Models.Request.List;

public class CreateListRequest
{
    public string Name { get; set; }
    
    public string? Content { get; set; }
    
    [Display("Due date")]
    [JsonConverter(typeof(UnixTimestampConverter))] 
    public DateTime? DueDate { get; set; }
    
    [Display("Due date time")]
    public bool? DueDateTime { get; set; }
    
    [StaticDataSource(typeof(TaskPriorityDataHandler))]
    public string? Priority { get; set; }
    
    [Display("Assignee ID")]
    public string? Assignee { get; set; }
    
    public string? Status { get; set; }

}