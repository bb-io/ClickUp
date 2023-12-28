using Apps.ClickUp.Models.Entities.Base;
using Apps.ClickUp.Models.Entities.Simple;
using Blackbird.Applications.Sdk.Common;

namespace Apps.ClickUp.Models.Entities;

public class ListEntity : ClickUpEntity
{
    
    [Display("List ID")]
    public string Id { get; set; }

    public int TaskCount { get; set; }

    [Display("Override statuses")]
    public bool OverrideStatuses { get; set; }
    
    public List<StatusModel> Statuses { get; set; }
    
    public SimpleFolder Folder { get; set; }
    
    public SimpleSpace Space { get; set; }
}