using Blackbird.Applications.Sdk.Common;

namespace ClickUp.Models.Request.Space;

public class UpdateSpaceRequest
{
    public string? Name { get; set; }
    public string? Color { get; set; }
    public bool? Private { get; set; }
    
    [Display("Admin can manage")]
    public bool? AdminCanManage { get; set; }
    
    [Display("Multiple assignees")]
    public bool? MultipleAssignees { get; set; }
}