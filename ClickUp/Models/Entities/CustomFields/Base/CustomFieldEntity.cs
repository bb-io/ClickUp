using Blackbird.Applications.Sdk.Common;

namespace ClickUp.Models.Entities.CustomFields.Base;

public class CustomFieldEntity
{
    [Display("Field ID")]
    public string Id { get; set; }
    
    public string Name { get; set; }
    
    public string Type { get; set; }
}