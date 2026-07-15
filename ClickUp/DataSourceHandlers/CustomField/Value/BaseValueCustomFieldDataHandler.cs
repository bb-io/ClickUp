using Apps.ClickUp.Api;
using Apps.ClickUp.Constants;
using Apps.ClickUp.Invocables;
using Apps.ClickUp.Models.Entities.CustomFields.Base;
using Apps.ClickUp.Models.Request.Task;
using Apps.ClickUp.Models.Response.Task;
using Blackbird.Applications.Sdk.Common.Exceptions;
using Blackbird.Applications.Sdk.Common.Invocation;
using Newtonsoft.Json;
using RestSharp;

namespace Apps.ClickUp.DataSourceHandlers.CustomField.Value;

public abstract class BaseValueCustomFieldDataHandler<TCustomField> : ClickUpInvocable
    where TCustomField : CustomFieldEntity
{
    private readonly string _taskId;
    private readonly string _fieldId;
    protected abstract string FieldType { get; }
    
    protected BaseValueCustomFieldDataHandler(
        InvocationContext invocationContext, 
        TaskRequest taskRequest,
        string fieldId) : base(invocationContext)
    {
        if (string.IsNullOrWhiteSpace(taskRequest.TaskId))
            throw new PluginMisconfigurationException("Please specify a task ID first");

        _taskId = taskRequest.TaskId;
        _fieldId = fieldId;
    }

    protected async Task<IEnumerable<TCustomField>> GetCustomFields()
    {
        var endpoint = $"{ApiEndpoints.Tasks}/{_taskId}";
        var request = new ClickUpRequest(endpoint, Method.Get, Creds);

        var response = await Client.ExecuteWithErrorHandling<TaskCustomFieldsResponse>(request);
        var serializer = JsonSerializer.Create(JsonConfig.Settings);

        return response.CustomFields
            .Where(f => f["type"]?.ToString() == FieldType)
            .Select(f => f.ToObject<TCustomField>(serializer)!)
            .Where(x => x.Id == _fieldId);
    }
}