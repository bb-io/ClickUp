using Apps.ClickUp.DataSourceHandlers;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Dynamic;

namespace Apps.ClickUp.Models.Request.Space;

public class SpaceRequest
{
    [Display("Space ID")] 
    [DataSource(typeof(SpaceDataHandler))]
    public string SpaceId { get; set; }
}