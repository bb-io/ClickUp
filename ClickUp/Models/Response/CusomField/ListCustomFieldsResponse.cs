using ClickUp.Models.Entities.CustomFields.Base;

namespace ClickUp.Models.Response.CusomField;

public record ListCustomFieldsResponse(IEnumerable<CustomFieldEntity> Fields);