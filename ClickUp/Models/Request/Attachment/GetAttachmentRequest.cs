using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Files;

namespace Apps.ClickUp.Models.Request.Attachment;

public class GetAttachmentRequest
{
    [Display("Task ID")]
    public string TaskId { get; set; }

    [Display("Attachment ID")]

    public string AttachmentId { get; set; }
}