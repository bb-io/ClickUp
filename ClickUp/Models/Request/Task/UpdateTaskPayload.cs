using Apps.ClickUp.Utils.Converters;
using Newtonsoft.Json;

namespace Apps.ClickUp.Models.Request.Task;

public class UpdateTaskPayload
{
    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? Status { get; set; }

    public string? Priority { get; set; }

    [JsonConverter(typeof(UnixTimestampConverter))]
    public DateTime? DueDate { get; set; }

    public bool? DueDateTime { get; set; }

    public int? TimeEstimate { get; set; }

    [JsonConverter(typeof(UnixTimestampConverter))]
    public DateTime? StartDate { get; set; }

    public bool? StartDateTime { get; set; }

    public string? Parent { get; set; }
}
