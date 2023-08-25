using ClickUp.Models.Entities;

namespace ClickUp.Models.Response.List;

public record ListListsResponse
{
    public IEnumerable<ListWithFolderEntity> Lists { get; set; }
}