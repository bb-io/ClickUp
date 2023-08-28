using Blackbird.Applications.Sdk.Common;
using File = Blackbird.Applications.Sdk.Common.Files.File;

namespace ClickUp.Models.Request.Attachment;

public class CreateAttachmentRequest
{
    [Display("Task ID")]
    public string TaskId { get; set; }
    
    public File File { get; set; }
    
    [Display("File name")]
    public string? FileName { get; set; }
}