using Apps.ClickUp.DataSourceHandlers.Folder;
using Apps.ClickUp.DataSourceHandlers.List;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Dynamic;

namespace Apps.ClickUp.Models.Request.List;

public class ListRequest
{
    [Display("Folder ID")]
    [DataSource(typeof(FolderDataHandler))]
    public string FolderId { get; set; }

    [Display("List ID")]
    [DataSource(typeof(PrimaryListDataHandler))]
    public string ListId { get; set; }
}