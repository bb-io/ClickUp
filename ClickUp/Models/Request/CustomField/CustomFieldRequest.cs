using Apps.ClickUp.DataSourceHandlers;
using Apps.ClickUp.DataSourceHandlers.Folder;
using Apps.ClickUp.DataSourceHandlers.List;
using Apps.ClickUp.DataSourceHandlers.Space;
using Apps.ClickUp.DataSourceHandlers.Task;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Dynamic;

namespace Apps.ClickUp.Models.Request.CustomField;

public class CustomFieldRequest
{
    [Display("Team")]
    [DataSource(typeof(TeamDataHandler))]
    public string TeamId { get; set; }

    [Display("Space ID")]
    [DataSource(typeof(SpaceCustomFieldDataHandler))]
    public string SpaceId { get; set; }

    [Display("Folder ID")]
    [DataSource(typeof(FolderCustomFieldDataHandler))]
    public string FolderId { get; set; }
    
    [Display("List ID")]
    [DataSource(typeof(ListCustomFieldDataHandler))]
    public string ListId { get; set; }
    
    [Display("Task ID")]
    [DataSource(typeof(TaskCustomFieldDataHandler))]
    public string TaskId { get; set; }
    
    [Display("Field ID")]
    [DataSource(typeof(CustomFieldDataHandler))]
    public string FieldId { get; set; }
}