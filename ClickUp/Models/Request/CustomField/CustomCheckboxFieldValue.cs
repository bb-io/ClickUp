using Blackbird.Applications.Sdk.Common;

namespace Apps.ClickUp.Models.Request.CustomField;

public class CustomCheckboxFieldValue
{
    [Display("Value")]
    public bool Value { get; set; }
}