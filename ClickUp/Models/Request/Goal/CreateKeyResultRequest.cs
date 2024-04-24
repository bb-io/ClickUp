using Apps.ClickUp.DataSourceHandlers.Static;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Dictionaries;

namespace Apps.ClickUp.Models.Request.Goal;

public class CreateKeyResultRequest
{
    public string Name { get; set; }
    public IEnumerable<string>? Owners { get; set; }
    
    [StaticDataSource(typeof(KeyResultTypeDataHandler))]
    public string Type { get; set; }
    
    [Display("Steps start")]
    public int? StepsStart { get; set; }
    
    [Display("Steps end")]
    public int StepsEnd { get; set; }
    
    public string? Unit { get; set; }
    
    [Display("Task IDs")]
    public IEnumerable<string>? TaskIds { get; set; }
    
    [Display("List IDs")]
    public IEnumerable<string>? ListIds { get; set; }
}