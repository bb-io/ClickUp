using Apps.ClickUp.DataSourceHandlers;
using Apps.ClickUp.DataSourceHandlers.Folder;
using Apps.ClickUp.DataSourceHandlers.List;
using Apps.ClickUp.DataSourceHandlers.Space;
using Apps.ClickUp.DataSourceHandlers.Task;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Dynamic;

namespace Apps.ClickUp.Models.Request.Task;

public class TaskRequest
{
    [Display("Team")]
    [DataSource(typeof(TeamDataHandler))]
    public string TeamId { get; set; }

    [Display("Space ID")]
    [DataSource(typeof(SpaceTaskDataHandler))]
    public string SpaceId { get; set; }

    [Display("Folder ID")]
    [DataSource(typeof(FolderTaskDataHandler))]
    public string FolderId { get; set; }
    
    [Display("List ID")]
    [DataSource(typeof(ListTaskDataHandler))]
    public string ListId { get; set; }
    
    [Display("Task ID")]
    [DataSource(typeof(PrimaryTaskDataHandler))]
    public string TaskId { get; set; }
}