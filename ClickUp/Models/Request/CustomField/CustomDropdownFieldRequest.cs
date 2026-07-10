using Apps.ClickUp.DataSourceHandlers;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Dynamic;

namespace Apps.ClickUp.Models.Request.CustomField;

public class CustomDropdownFieldRequest
{
    [Display("Dropdown ID"), DataSource(typeof(DropdownCustomFieldDataHandler))]
    public string Id { get; set; } = string.Empty;
}