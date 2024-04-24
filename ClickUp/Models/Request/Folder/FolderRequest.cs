using Apps.ClickUp.DataSourceHandlers;
using Apps.ClickUp.DataSourceHandlers.Folder;
using Apps.ClickUp.DataSourceHandlers.Space;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Dynamic;

namespace Apps.ClickUp.Models.Request.Folder;

public class FolderRequest
{
    [Display("Team")]
    [DataSource(typeof(TeamDataHandler))]
    public string TeamId { get; set; }

    [Display("Space ID")]
    [DataSource(typeof(SpaceFolderDataHandler))]
    public string SpaceId { get; set; }

    [Display("Folder ID")]
    [DataSource(typeof(PrimaryFolderDataHandler))]
    public string FolderId { get; set; }
}