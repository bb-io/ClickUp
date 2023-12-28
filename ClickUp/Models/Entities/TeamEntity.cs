using Blackbird.Applications.Sdk.Common;

namespace Apps.ClickUp.Models.Entities;

public class TeamEntity
{
    [Display("ID")]
    public string Id { get; set; }

    public string Name { get; set; }

    public string Color { get; set; }

    public string Avatar { get; set; }
}