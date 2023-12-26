using Blackbird.Applications.Sdk.Common;

namespace Apps.ClickUp.Models.Request.CustomField;

public class CustomFieldNameRequest
{
    [Display("Custom field name")]
    public string Name { get; set; }
}