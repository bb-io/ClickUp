using Blackbird.Applications.Sdk.Common;

namespace ClickUp.Models.Request.Space;

public class CreateSpaceRequest
{
    public string Name { get; set; }
    
    [Display("Multiple assignees")]
    public bool MultipleAssignees { get; set; }
}