using Apps.ClickUp.Actions.Base;
using Apps.ClickUp.Api;
using Apps.ClickUp.Constants;
using Apps.ClickUp.Models.Entities;
using Apps.ClickUp.Models.Entities.CustomFields;
using Apps.ClickUp.Models.Entities.CustomFields.Base;
using Apps.ClickUp.Models.Entities.CustomFields.Dropdown;
using Apps.ClickUp.Models.Entities.CustomFields.Label;
using Apps.ClickUp.Models.Request;
using Apps.ClickUp.Models.Request.CustomField;
using Apps.ClickUp.Models.Request.List;
using Apps.ClickUp.Models.Request.Task;
using Apps.ClickUp.Models.Response.CustomField;
using Apps.ClickUp.Models.Response.Task;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Exceptions;
using Blackbird.Applications.Sdk.Common.Invocation;
using Blackbird.Applications.Sdk.Utils.Extensions.Http;
using Blackbird.Applications.Sdk.Utils.Extensions.String;
using Newtonsoft.Json;
using RestSharp;

namespace Apps.ClickUp.Actions;

[ActionList("Task")]
public class TaskActions(InvocationContext invocationContext) : ClickUpActions(invocationContext)
{
    [Action("Search tasks", Description = "Get all tasks given a specific list")]
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

    [Action("Update task", Description = "Update a specific task")]
    public Task<TaskEntity> UpdateTask([ActionParameter] UpdateTaskRequest input)
    {
        var endpoint = $"{ApiEndpoints.Tasks}/{input.TaskId}";
        var requestBody = new UpdateTaskPayload
        {
            Name = input.Name,
            Description = input.Description,
            Status = input.Status,
            Priority = input.Priority,
            DueDate = input.DueDate,
            DueDateTime = GetTimeFlag(input.DueDate),
            TimeEstimate = GetTimeEstimate(input.TimeEstimate),
            StartDate = input.StartDate,
            StartDateTime = GetTimeFlag(input.StartDate),
            Parent = input.Parent
        };

        var request = new ClickUpRequest(endpoint, Method.Put, Creds)
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

    [Action("Get task string custom field", Description = "Get task custom field with a string value")]
    public async Task<StringCustomFieldEntity> GetTaskStringCustomField(
        [ActionParameter] TaskRequest taskInput,
        [ActionParameter] CustomStringFieldRequest fieldInput)
    {
        return await GetTaskCustomField<StringCustomFieldEntity>(taskInput.TaskId, fieldInput.FieldId, "text", "short_text");
    }

    [Action("Get task number custom field", Description = "Get task custom field with a number value")]
    public async Task<NumberCustomFieldEntity> GetTaskNumberCustomField(
        [ActionParameter] TaskRequest taskInput,
        [ActionParameter] CustomNumberFieldRequest fieldInput)
    {
        return await GetTaskCustomField<NumberCustomFieldEntity>(taskInput.TaskId, fieldInput.FieldId, "number");
    }

    [Action("Get task date custom field", Description = "Get task custom field with a date value")]
    public async Task<DateCustomFieldEntity> GetTaskDateCustomField(
        [ActionParameter] TaskRequest taskInput,
        [ActionParameter] CustomDateFieldRequest fieldInput)
    {
        return await GetTaskCustomField<DateCustomFieldEntity>(taskInput.TaskId, fieldInput.FieldId, "date");
    }

    [Action("Get task location custom field", Description = "Get task custom field with a location value")]
    public async Task<GetTaskLocationCustomFieldResponse> GetTaskLocationCustomField(
        [ActionParameter] TaskRequest taskInput,
        [ActionParameter] CustomLocationFieldRequest fieldInput)
    {
        var locationField = await GetTaskCustomField<LocationCustomFieldEntity>(taskInput.TaskId, fieldInput.FieldId, "location");
        return new(locationField);
    }

    [Action("Get task dropdown custom field", Description = "Get task custom field with a dropdown value")]
    public async Task<GetTaskDropdownCustomFieldResponse> GetTaskDropdownCustomField(
        [ActionParameter] TaskRequest taskInput,
        [ActionParameter] CustomDropdownFieldRequest fieldInput)
    {
        var locationField = await GetTaskCustomField<DropdownCustomFieldEntity>(taskInput.TaskId, fieldInput.FieldId, "drop_down");
        return new(locationField);
    }

    [Action("Get task label custom field", Description = "Get task custom field with label values")]
    public async Task<GetTaskLabelCustomFieldResponse> GetTaskLabelCustomField(
        [ActionParameter] TaskRequest taskInput,
        [ActionParameter] CustomLabelFieldRequest labelFieldInput)
    {
        var locationField = await GetTaskCustomField<LabelCustomFieldEntity>(taskInput.TaskId, labelFieldInput.FieldId, "labels");
        return new(locationField);
    }
    
    #endregion
    
    private async Task<TEntity> GetTaskCustomField<TEntity>(
        string taskId,
        string fieldId,
        params string[] expectedTypes)
        where TEntity : CustomFieldEntity
    {
        var endpoint = $"{ApiEndpoints.Tasks}/{taskId}";
        var request = new ClickUpRequest(endpoint, Method.Get, Creds);
        var response = await Client.ExecuteWithErrorHandling<TaskCustomFieldsResponse>(request);

        var match = response.CustomFields.FirstOrDefault(f => string.Equals(f["id"]?.ToString(), fieldId, StringComparison.OrdinalIgnoreCase));
        if (match is null)
            throw new PluginMisconfigurationException($"No custom field with ID '{fieldId}' was found on this task.");

        var actualType = match["type"]?.ToString();
        if (!expectedTypes.Contains(actualType))
        {
            throw new PluginMisconfigurationException(
                $"Custom field '{fieldId}' is type '{actualType}', but this action expects: {string.Join(", ", expectedTypes)}.");
        }

        return match.ToObject<TEntity>(JsonSerializer.Create(JsonConfig.Settings))!;
    }

    private static bool? GetTimeFlag(DateTime? value)
        => value.HasValue ? value.Value.TimeOfDay != TimeSpan.Zero : null;

    private static int? GetTimeEstimate(int? value)
        => value.HasValue ? checked(value.Value * 60 * 60 * 1000) : null;
}
