using Blackbird.Applications.Sdk.Common;

namespace Apps.ClickUp.Models.Request.CustomField;

public class CustomFieldDateValue
{
    [Display("Value")]
    public DateTime Value { get; set; }
}