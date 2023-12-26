namespace Apps.ClickUp.Webhooks.Models.Request;

public class AddWebhookRequest
{
    public string Endpoint { get; set; }
    public List<string> Events { get; set; }
}