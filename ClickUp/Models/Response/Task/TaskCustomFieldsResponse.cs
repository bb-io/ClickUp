using Newtonsoft.Json.Linq;

namespace Apps.ClickUp.Models.Response.Task;

public class TaskCustomFieldsResponse
{
    public JArray CustomFields { get; set; }
}