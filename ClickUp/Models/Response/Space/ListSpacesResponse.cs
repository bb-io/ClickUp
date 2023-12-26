using Apps.ClickUp.Models.Entities;

namespace Apps.ClickUp.Models.Response.Space;

public class ListSpacesResponse
{
    public IEnumerable<SpaceEntity> Spaces { get; set; }
}