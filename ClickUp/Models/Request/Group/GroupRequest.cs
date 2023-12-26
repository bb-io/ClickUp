using Blackbird.Applications.Sdk.Common;

namespace Apps.ClickUp.Models.Request.Group;

public class GroupRequest
{
    [Display("User group ID")]
    public string GroupId { get; set; }
}