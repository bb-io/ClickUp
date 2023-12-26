using Newtonsoft.Json;

namespace Apps.ClickUp.Webhooks.Models.Payloads.Additional;

public class WebhooksResponse
{
    [JsonProperty("webhooks")]
    public List<Webhook> Webhooks { get; set; }
}