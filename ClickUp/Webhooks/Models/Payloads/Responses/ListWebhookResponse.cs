using Blackbird.Applications.Sdk.Common;
using ClickUp.Webhooks.Models.Payloads.Base;

namespace ClickUp.Webhooks.Models.Payloads.Responses;

public class ListWebhookResponse : ClickUpWebhookResponse
{
    [Display("List ID")]
    public string ListId { get; set; }
}