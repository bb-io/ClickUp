using ClickUp.Models.Entities;

namespace ClickUp.Models.Response.Space;

public class ListSpacesResponse
{
    public IEnumerable<SpaceEntity> Spaces { get; set; }
}