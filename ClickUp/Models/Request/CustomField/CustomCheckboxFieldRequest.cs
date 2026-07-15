using Apps.ClickUp.DataSourceHandlers.CustomField;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Dynamic;

namespace Apps.ClickUp.Models.Request.CustomField;

public class CustomCheckboxFieldRequest
{
    [Display("Checkbox field ID"), DataSource(typeof(CheckboxCustomFieldDataHandler))]
    public string FieldId { get; set; } = string.Empty;
}