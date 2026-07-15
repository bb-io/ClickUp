using Apps.ClickUp.Api;
using Apps.ClickUp.Constants;
using Apps.ClickUp.Extensions;
using Apps.ClickUp.Invocables;
using Apps.ClickUp.Models.Entities.CustomFields.Label;
using Apps.ClickUp.Models.Request.CustomField;
using Apps.ClickUp.Models.Request.Task;
using Apps.ClickUp.Models.Response.Task;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Dynamic;
using Blackbird.Applications.Sdk.Common.Exceptions;
using Blackbird.Applications.Sdk.Common.Invocation;
using Newtonsoft.Json;
using RestSharp;

namespace Apps.ClickUp.DataSourceHandlers.CustomField.Value;

public class LabelValueCustomFieldDataHandler : ClickUpInvocable, IAsyncDataSourceItemHandler
{
    private readonly string _taskId;
    private readonly string _labelId;
    
    public LabelValueCustomFieldDataHandler(
        InvocationContext invocationContext, 
        [ActionParameter] TaskRequest taskRequest,
        [ActionParameter] CustomLabelFieldRequest fieldRequest) : base(invocationContext)
    {
        if (string.IsNullOrWhiteSpace(taskRequest.TaskId))
            throw new PluginMisconfigurationException("Please specify a task ID first");

        if (string.IsNullOrWhiteSpace(fieldRequest.FieldId))
            throw new PluginMisconfigurationException("Please specify a label ID first");
        
        _taskId = taskRequest.TaskId;
        _labelId = fieldRequest.FieldId;
    }
    
    public async Task<IEnumerable<DataSourceItem>> GetDataAsync(DataSourceContext context, CancellationToken cancellationToken)
    {
        var endpoint = $"{ApiEndpoints.Tasks}/{_taskId}";
        var request = new ClickUpRequest(endpoint, Method.Get, Creds);

        var response = await Client.ExecuteWithErrorHandling<TaskCustomFieldsResponse>(request);
        var serializer = JsonSerializer.Create(JsonConfig.Settings);

        var options = response.CustomFields
            .Where(f => f["type"]?.ToString() == "labels")
            .Select(f => f.ToObject<LabelCustomFieldEntity>(serializer)!)
            .Where(x => x.Id == _labelId)
            .SelectMany(f => f.TypeConfig.Options);

        return options
            .Where(x => x.Label.ContainsIgnoreCase(context.SearchString))
            .Select(x => new DataSourceItem(x.Id, x.Label))
            .ToList();
    }
}