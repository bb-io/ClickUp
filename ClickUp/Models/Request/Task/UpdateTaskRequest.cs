using Apps.ClickUp.DataSourceHandlers;
using Apps.ClickUp.DataSourceHandlers.List;
using Apps.ClickUp.DataSourceHandlers.Static;
using Apps.ClickUp.DataSourceHandlers.Task;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Dictionaries;
using Blackbird.Applications.Sdk.Common.Dynamic;

namespace Apps.ClickUp.Models.Request.Task;

public class UpdateTaskRequest
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

    public string? Name { get; set; }

    public string? Description { get; set; }

    [DataSource(typeof(TaskStatusDataHandler))]
    public string? Status { get; set; }

    [StaticDataSource(typeof(TaskPriorityDataHandler))]
    public string? Priority { get; set; }

    [Display("Due date")]
    public DateTime? DueDate { get; set; }

    [Display("Time estimate")]
    public int? TimeEstimate { get; set; }

    [Display("Start date")]
    public DateTime? StartDate { get; set; }

    [DataSource(typeof(TaskParentDataHandler))]
    public string? Parent { get; set; }
}
