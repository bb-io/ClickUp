using Blackbird.Applications.Sdk.Common;

namespace Apps.ClickUp.Models.Entities.Simple;

public class SimpleList
{
    [Display("List ID")]
    public string Id { get; set; }
    
    [Display("List name")]
    public string Name { get; set; }
}