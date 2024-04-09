using Blackbird.Applications.Sdk.Common;

namespace Apps.ClickUp.Models.Request.Group;

public class CreateGroupRequest
{
    public string Name { get; set; }
    
    [Display("Member IDs")]
    public IEnumerable<string> Members { get; set; }
}