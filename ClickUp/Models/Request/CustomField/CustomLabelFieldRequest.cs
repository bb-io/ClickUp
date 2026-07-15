using Apps.ClickUp.DataSourceHandlers.CustomField;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Dynamic;

namespace Apps.ClickUp.Models.Request.CustomField;

public class CustomLabelFieldRequest
{
    [Display("Label field ID"), DataSource(typeof(LabelCustomFieldDataHandler))]
    public string FieldId { get; set; } = string.Empty;
}