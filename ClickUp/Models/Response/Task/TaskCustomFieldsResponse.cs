using Newtonsoft.Json.Linq;

namespace ClickUp.Models.Response.Task;

public class TaskCustomFieldsResponse
{
    public JArray CustomFields { get; set; }
}