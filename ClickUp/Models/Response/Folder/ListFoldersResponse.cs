using ClickUp.Models.Entities;

namespace ClickUp.Models.Response.Folder;

public class ListFoldersResponse
{
    public IEnumerable<FolderEntity> Folders { get; set; }
}