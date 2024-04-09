using Apps.ClickUp.Models.Entities;

namespace Apps.ClickUp.Models.Response.Team;

public class ListTeamsResponse
{
    public IEnumerable<TeamEntity> Teams { get; set; }
}