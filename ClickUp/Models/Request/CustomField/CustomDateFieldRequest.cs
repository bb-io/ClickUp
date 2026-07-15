using Apps.ClickUp.DataSourceHandlers.CustomField;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Dynamic;

namespace Apps.ClickUp.Models.Request.CustomField;

public class CustomDateFieldRequest
{
    [Display("Date field ID"), DataSource(typeof(DateCustomFieldDataHandler))]
    public string FieldId { get; set; } = string.Empty;
}