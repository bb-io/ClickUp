using Apps.ClickUp.Models.Entities.CustomFields.Base;
using Newtonsoft.Json;

namespace Apps.ClickUp.Models.Response.Task;

public class TaskCustomFieldsConcreteResponse
{
    [JsonProperty("custom_fields")] 
    public List<CustomFieldEntity> CustomFields { get; set; } = [];
}