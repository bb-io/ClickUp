using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Files;

namespace Apps.ClickUp.Models.Request.Attachment;

public class DownloadAttachmentRequest
{
    [Display("Attachment URL")]

    public string AttachmentURL {  get; set; }
}