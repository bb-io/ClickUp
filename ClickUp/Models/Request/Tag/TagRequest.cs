using Apps.ClickUp.DataSourceHandlers;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Dynamic;

namespace Apps.ClickUp.Models.Request.Tag;

public class TagRequest
{
    [Display("Tag name")]
    [DataSource(typeof(TagDataHandler))]
    public string TagName { get; set; }
}