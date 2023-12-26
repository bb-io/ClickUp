using Apps.ClickUp.Models.Request.Task;
using Blackbird.Applications.Sdk.Common;

namespace Apps.ClickUp.Models.Request.CustomField;

public class CustomFieldRequest : TaskRequest
{
    [Display("Field ID")]
    public string FieldId { get; set; }
}