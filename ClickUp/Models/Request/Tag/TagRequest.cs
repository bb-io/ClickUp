using Apps.ClickUp.DataSourceHandlers;
using Apps.ClickUp.DataSourceHandlers.Space;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Dynamic;

namespace Apps.ClickUp.Models.Request.Tag;

public class TagRequest
{
    [Display("Team")]
    [DataSource(typeof(TeamDataHandler))]
    public string TeamId { get; set; }

    [Display("Space ID")] 
    [DataSource(typeof(SpaceTagDataHandler))]
    public string SpaceId { get; set; }
    
    [Display("Tag name")]
    [DataSource(typeof(TagDataHandler))]
    public string TagName { get; set; }
}