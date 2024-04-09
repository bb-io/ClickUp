using Blackbird.Applications.Sdk.Common;

namespace Apps.ClickUp.Webhooks.Models.Payloads.Responses;

public class FolderWebhookResponse
{
    [Display("Folder ID")]
    public string FolderId { get; set; }
}