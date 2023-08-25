using Blackbird.Applications.Sdk.Common;
using ClickUp.Models.Entities.Base;

namespace ClickUp.Models.Entities;

public class ListWithFolderEntity : ClickUpEntity
{
    
    [Display("List ID")]
    public string Id { get; set; }

    public int TaskCount { get; set; }

    [Display("Override statuses")]
    public bool OverrideStatuses { get; set; }
}