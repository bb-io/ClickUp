using Blackbird.Applications.Sdk.Common;

namespace ClickUp.Models.Entities.Simple;

public class SimpleCustomField
{
    [Display("Custom field ID")]
    public string Id { get; set; }

    public string Value { get; set; }
}