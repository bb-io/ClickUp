using Blackbird.Applications.Sdk.Common;

namespace Apps.ClickUp.Models.Request.Tag;

public class TagRequest
{
    [Display("Tag name")]
    public string TagName { get; set; }
}