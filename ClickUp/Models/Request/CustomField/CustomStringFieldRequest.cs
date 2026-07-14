using Apps.ClickUp.DataSourceHandlers.CustomField;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Dynamic;

namespace Apps.ClickUp.Models.Request.CustomField;

public class CustomStringFieldRequest
{
    [Display("String field ID"), DataSource(typeof(StringCustomFieldDataHandler))]
    public string FieldId { get; set; } = string.Empty;
}