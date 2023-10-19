using ClickUp.Models.Entities.CustomFields.Base;
using ClickUp.Utils.Converters;
using Newtonsoft.Json;

namespace ClickUp.Models.Entities.CustomFields;

public class DateCustomFieldEntity : CustomFieldEntity
{
    [JsonConverter(typeof(UnixTimestampConverter))]
    public DateTime Value { get; set; }
}