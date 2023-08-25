using ClickUp.Models.Entities;

namespace ClickUp.Models.Response.Task;

public class ListTasksResponse
{
    public IEnumerable<TaskEntity> Tasks { get; set; }
}