using Blackbird.Applications.Sdk.Common;

namespace ClickUp.Models.Request.Tag;

public class CreateTagInput
{
    public string Name { get; set; }
    
    [Display("Foreground color")]
    public string? TagFg { get; set; }
    
    [Display("Background color")]
    public string? TagBg { get; set; }
}