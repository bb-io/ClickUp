using Blackbird.Applications.Sdk.Common;
using ClickUp.Models.Request.Task;

namespace ClickUp.Models.Request.CustomField;

public class CustomFieldRequest : TaskRequest
{
    [Display("Field ID")]
    public string FieldId { get; set; }
}