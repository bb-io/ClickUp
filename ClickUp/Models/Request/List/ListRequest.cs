using Apps.ClickUp.DataSourceHandlers;
using Apps.ClickUp.DataSourceHandlers.Folder;
using Apps.ClickUp.DataSourceHandlers.List;
using Apps.ClickUp.DataSourceHandlers.Space;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Dynamic;

namespace Apps.ClickUp.Models.Request.List;

public class ListRequest
{
    [Display("Team")]
    [DataSource(typeof(TeamDataHandler))]
    public string TeamId { get; set; }

    [Display("Space ID")]
    [DataSource(typeof(SpaceListDataHandler))]
    public string SpaceId { get; set; }

    [Display("Folder ID")]
    [DataSource(typeof(FolderListDataHandler))]
    public string FolderId { get; set; }
    
    [Display("List ID")]
    [DataSource(typeof(PrimaryListDataHandler))]
    public string ListId { get; set; }
}