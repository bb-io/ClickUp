using Apps.ClickUp.Actions.Base;
using Apps.ClickUp.Api;
using Apps.ClickUp.Constants;
using Apps.ClickUp.Extensions;
using Apps.ClickUp.Models.Request;
using Apps.ClickUp.Models.Request.CustomField;
using Apps.ClickUp.Models.Request.List;
using Apps.ClickUp.Models.Request.Task;
using Apps.ClickUp.Models.Response.CustomField;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using Blackbird.Applications.Sdk.Utils.Extensions.Http;
using Blackbird.Applications.Sdk.Utils.Extensions.String;
using RestSharp;

namespace Apps.ClickUp.Actions;

[ActionList("Custom fields")]
public class CustomFieldActions(InvocationContext invocationContext) : ClickUpActions(invocationContext)
{
    [Action("Search custom fields", Description = "Search all accessible custom fields")]
    public async Task<ListCustomFieldsResponse> ListCustomFields(
        [ActionParameter] ListRequest list,
        [ActionParameter] SearchCustomFieldsRequest searchInput)
    {
        string endpoint = $"{ApiEndpoints.Lists}/{list.ListId}{ApiEndpoints.CustomFields}";
        var request = new ClickUpRequest(endpoint, Method.Get, Creds);
        
        var response = await Client.ExecuteWithErrorHandling<ListCustomFieldsResponse>(request);
        var customFields = response.Fields
            .Where(x => x.Type.EqualsIgnoreCase(searchInput.FieldType))
            .Where(x => x.Name.ContainsIgnoreCase(searchInput.FieldNameContains))
            .ToList();

        return new(customFields);
    }

    [Action("Remove custom field value", Description = "Remove value of a specific custom field for the task")]
    public Task RemoveCustomFieldValue(
        [ActionParameter] CustomFieldRequest field,
        [ActionParameter] CreateRequestQuery query)
    {
        var endpoint = $"{ApiEndpoints.Tasks}/{field.TaskId}{ApiEndpoints.CustomFields}/{field.FieldId}";
        var request = new ClickUpRequest(endpoint.WithQuery(query), Method.Delete, Creds);

        return Client.ExecuteWithErrorHandling(request);
    }

    #region Set value actions

    [Action("Set string custom field value",
        Description = "Set string value of a specific custom field (URL, Dropdown, Email, Phone, Text)")]
    public Task SetStringCustomFieldValue(
        [ActionParameter] CustomFieldRequest field,
        [ActionParameter] CreateRequestQuery query,
        [ActionParameter] CustomFieldStringValue value)
        => SetCustomFieldValue(field.TaskId, field.FieldId, query, value);

    [Action("Set number custom field value", Description = "Set number value of a specific custom field (Number, Money, Emoji)")]
    public Task SetNumberCustomFieldValue(
        [ActionParameter] CustomFieldRequest field,
        [ActionParameter] CreateRequestQuery query,
        [ActionParameter] CustomFieldNumberValue value)
        => SetCustomFieldValue(field.TaskId, field.FieldId, query, value);

    [Action("Set date custom field value", Description = "Set date value of a specific custom field")]
    public Task SetDateCustomFieldValue(
        [ActionParameter] CustomFieldRequest field,
        [ActionParameter] CreateRequestQuery query,
        [ActionParameter] CustomFieldDateValue value)
        => SetCustomFieldValue(field.TaskId, field.FieldId, query, value);

    [Action("Set location custom field value", Description = "Set location value of a specific custom field")]
    public Task SetLocationCustomFieldValue(
        [ActionParameter] CustomFieldRequest field,
        [ActionParameter] CreateRequestQuery query,
        [ActionParameter] CustomFieldLocationValue value)
        => SetCustomFieldValue(field.TaskId, field.FieldId, query, new CustomFieldLocationRequest(value));

    [Action("Set dropdown custom field value", Description = "Set dropdown value of a specific custom field")]
    public Task SetDropdownCustomFieldValue(
        [ActionParameter] TaskRequest taskInput,
        [ActionParameter] CreateRequestQuery query,
        [ActionParameter] CustomDropdownFieldRequest fieldInput,
        [ActionParameter] CustomDropdownFieldValue fieldValueInput)
    {
        var payload = new { value = fieldValueInput.DropdownValueId };
        return SetCustomFieldValue(taskInput.TaskId, fieldInput.Id, query, payload);
    }
    
    private Task SetCustomFieldValue(string taskId, string fieldId, CreateRequestQuery query, object value)
    {
        var endpoint = $"{ApiEndpoints.Tasks}/{taskId}{ApiEndpoints.CustomFields}/{fieldId}";
        var request = new ClickUpRequest(endpoint.WithQuery(query), Method.Post, Creds)
            .WithJsonBody(value, JsonConfig.Settings);

        return Client.ExecuteWithErrorHandling(request);
    }

    #endregion
}