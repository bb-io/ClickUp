using Apps.ClickUp.DataSourceHandlers.CustomField;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Dynamic;

namespace Apps.ClickUp.Models.Request.CustomField;

public class CustomNumberFieldRequest
{
    [Display("Number field ID"), DataSource(typeof(NumberCustomFieldDataHandler))]
    public string FieldId { get; set; } = string.Empty;
}