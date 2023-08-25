using Blackbird.Applications.Sdk.Common;

namespace ClickUp.Models.Request.Space;

public class SpaceRequest
{
    [Display("Space ID")]
    public string SpaceId { get; set; }
}