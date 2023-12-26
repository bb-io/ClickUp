using Apps.ClickUp.Models.Entities.CustomFields.Base;
using Apps.ClickUp.Utils.Converters;
using Newtonsoft.Json;

namespace Apps.ClickUp.Models.Entities.CustomFields;

public class DateCustomFieldEntity : CustomFieldEntity
{
    [JsonConverter(typeof(UnixTimestampConverter))]
    public DateTime Value { get; set; }
}