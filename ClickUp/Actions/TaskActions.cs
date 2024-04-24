using Apps.ClickUp.Actions.Base;
using Apps.ClickUp.Api;
using Apps.ClickUp.Constants;
using Apps.ClickUp.Models.Entities;
using Apps.ClickUp.Models.Entities.CustomFields;
using Apps.ClickUp.Models.Request;
using Apps.ClickUp.Models.Request.CustomField;
using Apps.ClickUp.Models.Request.List;
using Apps.ClickUp.Models.Request.Task;
using Apps.ClickUp.Models.Response.Task;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using Blackbird.Applications.Sdk.Utils.Extensions.Http;
using Blackbird.Applications.Sdk.Utils.Extensions.String;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace Apps.ClickUp.Actions;

[ActionList]
public class TaskActions : ClickUpActions
{
    public TaskActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get tasks", Description = "Get all tasks given a specific list")]
    public Task<ListTasksResponse> GetTasksFromList([ActionParameter] ListRequest list)
    {
        var endpoint = $"{ApiEndpoints.Lists}/{list.ListId}{ApiEndpoints.Tasks}";
        var request = new ClickUpRequest(endpoint, Method.Get, Creds);

        return Client.ExecuteWithErrorHandling<ListTasksResponse>(request);
    }

    [Action("Get task", Description = "Get the details of a specific task")]
    public Task<TaskEntity> GetTask([ActionParameter] TaskRequest task)
    {
        var endpoint = $"{ApiEndpoints.Tasks}/{task.TaskId}";
        var request = new ClickUpRequest(endpoint, Method.Get, Creds);

        return Client.ExecuteWithErrorHandling<TaskEntity>(request);
    }

    [Action("Create task", Description = "Create a new task")]
    public Task<TaskEntity> CreateTask(
        [ActionParameter] ListRequest list,
        [ActionParameter] CreateRequestQuery query,
        [ActionParameter] CreateTaskRequest requestBody)
    {
        var endpoint = $"{ApiEndpoints.Lists}/{list.ListId}{ApiEndpoints.Tasks}";
        var request = new ClickUpRequest(endpoint.WithQuery(query), Method.Post, Creds)
            .WithJsonBody(requestBody, JsonConfig.Settings);

        return Client.ExecuteWithErrorHandling<TaskEntity>(request);
    }

    [Action("Delete task", Description = "Delete specific task")]
    public Task DeleteTask([ActionParameter] TaskRequest task)
    {
        var endpoint = $"{ApiEndpoints.Tasks}/{task.TaskId}";
        var request = new ClickUpRequest(endpoint, Method.Delete, Creds);

        return Client.ExecuteWithErrorHandling(request);
    }

    #region Get custom field

    [Action("Get task string custom field",
        Description = "Get task custom field with a string value")]
    public async Task<StringCustomFieldEntity> GetTaskStringCustomField(
        [ActionParameter] TaskRequest task,
        [ActionParameter] CustomFieldNameRequest field)
    {
        var customFields = await ListTaskCustomFields(task);

        var result = customFields.CustomFields
            .FirstOrDefault(jObject =>
                jObject["name"]?.ToString() == field.Name && jObject["value"] is JValue { Type: JTokenType.String });

        if (result is null)
            throw new("No custom field found with the provided name");

        return result.ToObject<StringCustomFieldEntity>()!;
    }

    [Action("Get task number custom field",
        Description = "Get task custom field with a number value")]
    public async Task<NumberCustomFieldEntity> GetTaskNumberCustomField([ActionParameter] TaskRequest task,
        [ActionParameter] CustomFieldNameRequest field)
    {
        var customFields = await ListTaskCustomFields(task);

        var result = customFields.CustomFields
            .FirstOrDefault(jObject =>
                jObject["name"]?.ToString() == field.Name && int.TryParse(jObject["value"]?.ToString(), out _));

        if (result is null)
            throw new("No custom field found with the provided name");

        return result.ToObject<NumberCustomFieldEntity>()!;
    }

    [Action("Get task date custom field",
        Description = "Get task custom field with a date value")]
    public async Task<DateCustomFieldEntity> GetTaskDateCustomField([ActionParameter] TaskRequest task,
        [ActionParameter] CustomFieldNameRequest field)
    {
        var customFields = await ListTaskCustomFields(task);

        var result = customFields.CustomFields
            .FirstOrDefault(jObject =>
                jObject["name"]?.ToString() == field.Name && jObject["type"]?.ToString() == "date");

        if (result is null)
            throw new("No custom field found with the provided name");

        return result.ToObject<DateCustomFieldEntity>()!;
    }

    [Action("Get task location custom field",
        Description = "Get task custom field with a location value")]
    public async Task<LocationCustomFieldEntity> GetTaskLocationCustomField([ActionParameter] TaskRequest task,
        [ActionParameter] CustomFieldNameRequest field)
    {
        var customFields = await ListTaskCustomFields(task);

        var serializer = JsonSerializer.Create(JsonConfig.Settings);
        var result = customFields.CustomFields
            .FirstOrDefault(jObject =>
                jObject["name"]?.ToString() == field.Name && jObject["type"]?.ToString() == "location");

        if (result is null)
            throw new("No custom field found with the provided name");

        return result.ToObject<LocationCustomFieldEntity>(serializer)!;
    }

    private Task<TaskCustomFieldsResponse> ListTaskCustomFields(TaskRequest task)
    {
        var endpoint = $"{ApiEndpoints.Tasks}/{task.TaskId}";
        var request = new ClickUpRequest(endpoint, Method.Get, Creds);

        return Client.ExecuteWithErrorHandling<TaskCustomFieldsResponse>(request);
    }

    #endregion
}