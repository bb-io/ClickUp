using Blackbird.Applications.Sdk.Common;

namespace Apps.ClickUp.Models.Request.Space;

public class SpaceRequest
{
    [Display("Space ID")]
    public string SpaceId { get; set; }
}