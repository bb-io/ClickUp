using Apps.ClickUp.DataSourceHandlers.Static;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Dictionaries;

namespace Apps.ClickUp.Models.Request.CustomField;

public class SearchCustomFieldsRequest
{
    [Display("Field type"), StaticDataSource(typeof(FieldTypeDataHandler))]
    public string? FieldType { get; set; }

    [Display("Field name contains")]
    public string? FieldNameContains { get; set; }
}