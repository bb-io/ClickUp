using Apps.ClickUp.Models.Entities.CustomFields.Base;
using Apps.ClickUp.Models.Entities.CustomFields.Label;
using Blackbird.Applications.Sdk.Common;

namespace Apps.ClickUp.Models.Response.CustomField;

public class GetTaskLabelCustomFieldResponse : CustomFieldEntity
{
    public GetTaskLabelCustomFieldResponse(LabelCustomFieldEntity entity)
    {
        Id = entity.Id;
        Name = entity.Name;
        Type = entity.Type;

        var selectedLabelIds = entity.Value;
        var selectedLabels = entity.TypeConfig.Options.Where(x => selectedLabelIds.Contains(x.Id));
        Values = selectedLabels.Select(x => new TaskLabelCustomFieldValue { LabelValueId = x.Id, Label = x.Label}).ToList();
    }

    [Display("Values")]
    public List<TaskLabelCustomFieldValue> Values { get; set; }
}