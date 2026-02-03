using Apps.ClickUp.DataSourceHandlers;
using Apps.ClickUp.DataSourceHandlers.List;
using Apps.ClickUp.DataSourceHandlers.Task;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Dynamic;

namespace Apps.ClickUp.Models.Request.Task;

public class TaskRequest
{
    [Display("Folder ID")]
    [DataSource(typeof(FolderDataHandler))]
    public string FolderId { get; set; }

    [Display("List ID")]
    [DataSource(typeof(ListTaskDataHandler))]
    public string ListId { get; set; }

    [Display("Task ID")]
    [DataSource(typeof(PrimaryTaskDataHandler))]
    public string TaskId { get; set; }
}