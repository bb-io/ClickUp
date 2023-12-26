using Apps.ClickUp.Models.Entities.CustomFields.Base;

namespace Apps.ClickUp.Models.Response.CusomField;

public record ListCustomFieldsResponse(IEnumerable<CustomFieldEntity> Fields);