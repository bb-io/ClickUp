using Apps.ClickUp.DataSourceHandlers;
using Apps.ClickUp.DataSourceHandlers.Folder;
using Apps.ClickUp.DataSourceHandlers.Space;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Dynamic;

namespace Apps.ClickUp.Models.Request.Folder;

public class FolderRequest
{
    [Display("Folder ID")]
    [DataSource(typeof(FolderDataHandler))]
    public string FolderId { get; set; }
}