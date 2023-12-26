using Apps.ClickUp.Models.Entities;

namespace Apps.ClickUp.Models.Response.Folder;

public class ListFoldersResponse
{
    public IEnumerable<FolderEntity> Folders { get; set; }
}