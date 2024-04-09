using Apps.ClickUp.Utils.Converters;
using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.ClickUp.Models.Entities;

public class CustomField
{
    [Display("Custom field ID")]
    public string Id { get; set; }

    public string Name { get; set; }

    public string Type { get; set; }

    [Display("Date created")]
    [JsonConverter(typeof(UnixTimestampConverter))]
    public DateTime DateCreated { get; set; }

    [Display("Hide from guests")]
    public bool HideFromGuests { get; set; }

    public bool Required { get; set; }

    public List<string> Value { get; set; }
}