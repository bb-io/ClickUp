using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Dynamic;
using ClickUp.DataSourceHandlers.EnumHandlers;

namespace ClickUp.Models.Request.Goal;

public class CreateKeyResultRequest
{
    public string Name { get; set; }
    public IEnumerable<string>? Owners { get; set; }
    
    [DataSource(typeof(KeyResultTypeDataHandler))]
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