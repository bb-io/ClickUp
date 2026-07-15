using Blackbird.Applications.Sdk.Common;

namespace Apps.ClickUp.Models.Response.CustomField;

public class TaskLabelCustomFieldValue
{
    [Display("Label value ID")]
    public string LabelValueId { get; set; } = string.Empty;

    [Display("Label value")]
    public string Label { get; set; } = string.Empty;
}