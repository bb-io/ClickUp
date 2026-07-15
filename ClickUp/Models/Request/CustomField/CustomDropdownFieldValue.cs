using Apps.ClickUp.DataSourceHandlers;
using Apps.ClickUp.DataSourceHandlers.CustomField.Value;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Dynamic;

namespace Apps.ClickUp.Models.Request.CustomField;

public class CustomDropdownFieldValue
{
    [Display("Dropdown value ID"), DataSource(typeof(DropdownValueCustomFieldDataHandler))] 
    public string DropdownValueId { get; set; } = string.Empty;
}