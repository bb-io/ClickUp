using Apps.ClickUp.DataSourceHandlers.CustomField.Value;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Dynamic;

namespace Apps.ClickUp.Models.Request.CustomField;

public class CustomLabelFieldValue
{
    [Display("Label value IDs"), DataSource(typeof(LabelValueCustomFieldDataHandler))]
    public List<string> LabelValueIds { get; set; } = [];
}