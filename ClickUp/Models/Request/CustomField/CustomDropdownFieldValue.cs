using Blackbird.Applications.Sdk.Common;

namespace Apps.ClickUp.Models.Request.CustomField;

public class CustomDropdownFieldValue
{
    [Display("Dropdown ID")]
    public string Id { get; set; } = string.Empty;
    
    [Display("Dropdown value ID")] 
    public string DropdownValueId { get; set; } = string.Empty;
}