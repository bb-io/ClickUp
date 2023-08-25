using Blackbird.Applications.Sdk.Common;
using ClickUp.Models.Entities.Base;

namespace ClickUp.Models.Entities;

public class TaskEntity : ClickUpEntity
{
    [Display("ID")]
    public string Id { get; set; }

    [Display("Text content")]
    public string TextContent { get; set; }

    public string Description { get; set; }

    public StatusModel Status { get; set; }

    [Display("Date created")]
    public DateTime DateCreated { get; set; }

    [Display("Date updated")]
    public string DateUpdated { get; set; }

    [Display("Date closed")]
    public string DateClosed { get; set; }

    [Display("Date done")]
    public string DateDone { get; set; }

    [Display("Custom fields")]
    public IEnumerable<CustomField> CustomFields { get; set; }

    [Display("Team ID")]
    public string TeamId { get; set; }

    [Display("URL")]
    public string Url { get; set; }
    
    [Display("Time spent")]
    public int? TimeSpent { get; set; }
}