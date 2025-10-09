using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Files;

namespace Apps.ClickUp.Models.Request.Attachment;

public class CreateAttachmentRequest
{
    public FileReference File { get; set; }
    
    [Display("File name")]
    public string? FileName { get; set; }
}