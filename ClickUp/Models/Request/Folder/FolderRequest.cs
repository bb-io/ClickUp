using Blackbird.Applications.Sdk.Common;

namespace Apps.ClickUp.Models.Request.Folder;

public class FolderRequest
{
    [Display("Folder ID")]
    public string FolderId { get; set; }
}