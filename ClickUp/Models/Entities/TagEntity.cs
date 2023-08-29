using Blackbird.Applications.Sdk.Common;

namespace ClickUp.Models.Entities;

public class TagEntity
{
    public string Name { get; set; }
    
    [Display("Foreground color")]
    public string TagFg { get; set; }
    
    [Display("Background color")]
    public string TagBg { get; set; }
}