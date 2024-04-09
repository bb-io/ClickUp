using Blackbird.Applications.Sdk.Common;

namespace Apps.ClickUp.Models.Entities;

public class SpaceEntity
{
    [Display("Space ID")]
    public string Id { get; set; }

    public string Name { get; set; }

    public string Color { get; set; }

    public bool Private { get; set; }

    public string Avatar { get; set; }

    public List<StatusModel> Statuses { get; set; }

    [Display("Multiple assignees")]
    public bool MultipleAssignees { get; set; }

    public bool Archived { get; set; }
}