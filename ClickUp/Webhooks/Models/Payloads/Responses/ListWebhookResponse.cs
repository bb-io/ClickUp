using Apps.ClickUp.Webhooks.Models.Payloads.Base;
using Blackbird.Applications.Sdk.Common;

namespace Apps.ClickUp.Webhooks.Models.Payloads.Responses;

public class ListWebhookResponse : ClickUpWebhookResponse
{
    [Display("List ID")]
    public string ListId { get; set; }
}