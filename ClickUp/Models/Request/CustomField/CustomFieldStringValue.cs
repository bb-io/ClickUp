using Blackbird.Applications.Sdk.Common;

namespace Apps.ClickUp.Models.Request.CustomField;

public class CustomFieldStringValue
{
    [Display("Value")]
    public string Value { get; set; } = string.Empty;
}