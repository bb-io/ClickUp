using Blackbird.Applications.Sdk.Common;

namespace ClickUp.Webhooks.Models.Payloads.Responses;

public class SpaceWebhookResponse
{
    [Display("Space ID")]
    public string SpaceId { get; set; }
}