using Blackbird.Applications.Sdk.Common;
using ClickUp.Utils.Converters;
using Newtonsoft.Json;

namespace ClickUp.Models.Entities;

public class AttachmentEntity
{
    [Display("Attachment ID")]
    public string Id { get; set; }

    public string Version { get; set; }

    [JsonConverter(typeof(UnixTimestampConverter))]
    public DateTime Date { get; set; }

    public string Title { get; set; }

    public string Extension { get; set; }
    
    [Display("Small thumbnail")]

    public string ThumbnailSmall { get; set; }

    [Display("Large thumbnail")]
    public string ThumbnailLarge { get; set; }

    [Display("URL")]
    public string Url { get; set; }
}