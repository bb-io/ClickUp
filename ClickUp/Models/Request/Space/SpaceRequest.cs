using Apps.ClickUp.DataSourceHandlers;
using Apps.ClickUp.DataSourceHandlers.Space;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Dynamic;

namespace Apps.ClickUp.Models.Request.Space;

public class SpaceRequest
{
    [Display("Team")]
    [DataSource(typeof(TeamDataHandler))]
    public string TeamId { get; set; }

    [Display("Space ID")] 
    [DataSource(typeof(PrimarySpaceDataHandler))]
    public string SpaceId { get; set; }
}