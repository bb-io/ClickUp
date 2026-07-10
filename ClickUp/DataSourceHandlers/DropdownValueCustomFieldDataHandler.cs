using Apps.ClickUp.Api;
using Apps.ClickUp.Constants;
using Apps.ClickUp.Invocables;
using Apps.ClickUp.Models.Entities.CustomFields.Dropdown;
using Apps.ClickUp.Models.Request.CustomField;
using Apps.ClickUp.Models.Request.Task;
using Apps.ClickUp.Models.Response.Task;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Dynamic;
using Blackbird.Applications.Sdk.Common.Exceptions;
using Blackbird.Applications.Sdk.Common.Invocation;
using Newtonsoft.Json;
using RestSharp;

namespace Apps.ClickUp.DataSourceHandlers;

public class DropdownValueCustomFieldDataHandler : ClickUpInvocable, IAsyncDataSourceItemHandler
{
    private readonly string _taskId;
    private readonly string _dropdownId;
    
    public DropdownValueCustomFieldDataHandler(
        InvocationContext invocationContext, 
        [ActionParameter] TaskRequest taskRequest,
        [ActionParameter] CustomDropdownFieldRequest fieldRequest) : base(invocationContext)
    {
        if (string.IsNullOrWhiteSpace(taskRequest.TaskId))
            throw new PluginMisconfigurationException("Please specify a task ID first");

        if (string.IsNullOrWhiteSpace(fieldRequest.Id))
            throw new PluginMisconfigurationException("Please specify a dropdown ID first");
        
        _taskId = taskRequest.TaskId;
        _dropdownId = fieldRequest.Id;
    }
    
    public async Task<IEnumerable<DataSourceItem>> GetDataAsync(DataSourceContext context, CancellationToken cancellationToken)
    {
        var endpoint = $"{ApiEndpoints.Tasks}/{_taskId}";
        var request = new ClickUpRequest(endpoint, Method.Get, Creds);

        var response = await Client.ExecuteWithErrorHandling<TaskCustomFieldsResponse>(request);
        var serializer = JsonSerializer.Create(JsonConfig.Settings);

        var options = response.CustomFields
            .Where(f => f["type"]?.ToString() == "drop_down")
            .Select(f => f.ToObject<DropdownCustomFieldEntity>(serializer)!)
            .Where(x => x.Id == _dropdownId)
            .SelectMany(f => f.TypeConfig.Options);

        return options
            .Where(x => string.IsNullOrEmpty(context.SearchString) 
                        || x.Name.Contains(context.SearchString, StringComparison.OrdinalIgnoreCase))
            .Select(x => new DataSourceItem(x.Id, $"{x.OrderIndex}. {x.Name}"))
            .ToList();
    }
}