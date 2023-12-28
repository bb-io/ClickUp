using Apps.ClickUp.Models.Entities.Base;
using Apps.ClickUp.Models.Entities.Simple;
using Blackbird.Applications.Sdk.Common;

namespace Apps.ClickUp.Models.Entities;

public class FolderEntity : ClickUpEntity
{
    [Display("Folder ID")] public string Id { get; set; }

    [Display("Override statuses")] public bool OverrideStatuses { get; set; }

    public bool Hidden { get; set; }

    [Display("Task count")] public string TaskCount { get; set; }
    
    public SimpleSpace Space { get; set; }

    public List<ListEntity> Lists { get; set; }
}