using Blackbird.Applications.Sdk.Common;

namespace ClickUp.Models.Request.Folder;

public class FolderRequest
{
    [Display("Folder ID")]
    public string FolderId { get; set; }
}