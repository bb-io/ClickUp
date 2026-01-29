using Newtonsoft.Json;

namespace Apps.ClickUp.Webhooks.Models.Request;

public class AddWebhookRequest
{
    [JsonProperty("endpoint")]
    public string Endpoint { get; set; } = default!;

    [JsonProperty("events")]
    public List<string> Events { get; set; } = new();

    [JsonProperty("space_id")]
    public long? SpaceId { get; set; }

    [JsonProperty("folder_id")]
    public long? FolderId { get; set; }

    [JsonProperty("list_id")]
    public long? ListId { get; set; }

    [JsonProperty("task_id")]
    public string? TaskId { get; set; }
}