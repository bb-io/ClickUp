using Blackbird.Applications.Sdk.Common;

namespace Apps.ClickUp.Models.Request.CustomField;

public class CustomFieldNumberValue
{
    [Display("Value")]
    public long Value { get; set; }
}