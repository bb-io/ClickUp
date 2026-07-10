using Apps.ClickUp.Models.Entities.CustomFields.Base;

namespace Apps.ClickUp.Models.Response.CustomField;

public record ListCustomFieldsResponse(IEnumerable<CustomFieldEntity> Fields);