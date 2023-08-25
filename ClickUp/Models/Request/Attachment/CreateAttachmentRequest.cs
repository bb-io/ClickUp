using Blackbird.Applications.Sdk.Common;

namespace ClickUp.Models.Request.Attachment;

public class CreateAttachmentRequest
{
    [Display("Task ID")]
    public string TaskId { get; set; }
    
    public byte[] File { get; set; }
    
    [Display("File name")]
    public string FileName { get; set; }
}