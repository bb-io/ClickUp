using Apps.ClickUp.Models.Entities;

namespace Apps.ClickUp.Models.Response.Task;

public class ListTasksResponse
{
    public IEnumerable<TaskEntity> Tasks { get; set; }
}