using Apps.ClickUp.Models.Entities;

namespace Apps.ClickUp.Models.Response.List;

public record ListListsResponse
{
    public IEnumerable<ListEntity> Lists { get; set; }
}