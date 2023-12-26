using Apps.ClickUp.Utils.Converters;
using Newtonsoft.Json;

namespace Apps.ClickUp.Models.Request.CustomField;

public class CustomFieldDateValue
{
    [JsonConverter(typeof(UnixTimestampConverter))] 
    public DateTime Value { get; set; }
}