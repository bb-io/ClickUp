using ClickUp.Utils.Converters;
using Newtonsoft.Json;

namespace ClickUp.Models.Entities;

public class CustomField
{
    public string Id { get; set; }

    public string Name { get; set; }

    public string Type { get; set; }

    [JsonConverter(typeof(UnixTimestampConverter))]
    public DateTime DateCreated { get; set; }

    public bool HideFromGuests { get; set; }

    public bool Required { get; set; }

    public List<string> Value { get; set; }
}