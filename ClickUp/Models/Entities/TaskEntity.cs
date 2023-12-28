using Apps.ClickUp.Models.Entities.Base;
using Apps.ClickUp.Models.Entities.Simple;
using Apps.ClickUp.Utils.Converters;
using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.ClickUp.Models.Entities;

public class TaskEntity : ClickUpEntity
{
    [Display("ID")]
    public string Id { get; set; }

    [Display("Text content")]
    public string TextContent { get; set; }

    public string Description { get; set; }

    public StatusModel Status { get; set; }

    [Display("Date created")]
    [JsonConverter(typeof(UnixTimestampConverter))]
    public DateTime DateCreated { get; set; }

    [Display("Date updated")]
    [JsonConverter(typeof(UnixTimestampConverter))]
    public DateTime DateUpdated { get; set; }

    [Display("Date closed")]
    [JsonConverter(typeof(UnixTimestampConverter))]
    public DateTime? DateClosed { get; set; }

    [Display("Date done")]
    [JsonConverter(typeof(UnixTimestampConverter))]
    public DateTime? DateDone { get; set; }

    [Display("Custom fields")]
    public IEnumerable<CustomField> CustomFields { get; set; }

    [Display("Team ID")]
    public string TeamId { get; set; }

    [Display("URL")]
    public string Url { get; set; }
    
    [Display("Time spent")]
    public int? TimeSpent { get; set; }
    
    public SimpleList List { get; set; }
}