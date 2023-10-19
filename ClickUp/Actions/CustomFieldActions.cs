using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using Blackbird.Applications.Sdk.Utils.Extensions.Http;
using Blackbird.Applications.Sdk.Utils.Extensions.String;
using ClickUp.Actions.Base;
using ClickUp.Api;
using ClickUp.Constants;
using ClickUp.Models.Request;
using ClickUp.Models.Request.CustomField;
using ClickUp.Models.Request.List;
using ClickUp.Models.Response.CusomField;
using RestSharp;

namespace ClickUp.Actions;

[ActionList]
public class CustomFieldActions : ClickUpActions
{
    public CustomFieldActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("List custom fields", Description = "List all accessible custom fields")]
    public Task<ListCustomFieldsResponse> ListCustomFields([ActionParameter] ListRequest list)
    {
        var endpoint = $"{ApiEndpoints.Lists}/{list.ListId}{ApiEndpoints.CustomFields}";
        var request = new ClickUpRequest(endpoint, Method.Get, Creds);

        return Client.ExecuteWithErrorHandling<ListCustomFieldsResponse>(request);
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
        => SetCustomFieldValue(field, query, value);

    [Action("Set number custom field value",
        Description = "Set number value of a specific custom field (Number, Money, Emoji)")]
    public Task SetNumberCustomFieldValue(
        [ActionParameter] CustomFieldRequest field,
        [ActionParameter] CreateRequestQuery query,
        [ActionParameter] CustomFieldNumberValue value)
        => SetCustomFieldValue(field, query, value);

    [Action("Set date custom field value",
        Description = "Set date value of a specific custom field")]
    public Task SetDateCustomFieldValue(
        [ActionParameter] CustomFieldRequest field,
        [ActionParameter] CreateRequestQuery query,
        [ActionParameter] CustomFieldDateValue value)
        => SetCustomFieldValue(field, query, value);

    [Action("Set location custom field value",
        Description = "Set location value of a specific custom field")]
    public Task SetLocationCustomFieldValue(
        [ActionParameter] CustomFieldRequest field,
        [ActionParameter] CreateRequestQuery query,
        [ActionParameter] CustomFieldLocationValue value)
        => SetCustomFieldValue(field, query, new CustomFieldLocationRequest(value));

    private Task SetCustomFieldValue(CustomFieldRequest field, CreateRequestQuery query, object value)
    {
        var endpoint = $"{ApiEndpoints.Tasks}/{field.TaskId}{ApiEndpoints.CustomFields}/{field.FieldId}";
        var request = new ClickUpRequest(endpoint.WithQuery(query), Method.Post, Creds)
            .WithJsonBody(value, JsonConfig.Settings);

        return Client.ExecuteWithErrorHandling(request);
    }

    #endregion
}