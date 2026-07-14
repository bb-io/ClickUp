using Apps.ClickUp.DataSourceHandlers.CustomField;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Dynamic;

namespace Apps.ClickUp.Models.Request.CustomField;

public class CustomLocationFieldRequest
{
    [Display("Location field ID"), DataSource(typeof(LocationCustomFieldDataHandler))]
    public string FieldId { get; set; } = string.Empty;
}