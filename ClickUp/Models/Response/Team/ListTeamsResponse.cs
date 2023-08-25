using ClickUp.Models.Entities;

namespace ClickUp.Models.Response.Team;

public class ListTeamsResponse
{
    public IEnumerable<TeamEntity> Teams { get; set; }
}