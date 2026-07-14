using Apps.ClickUp.Api;
using Apps.ClickUp.Constants;
using Apps.ClickUp.Extensions;
using Apps.ClickUp.Invocables;
using Apps.ClickUp.Models.Request.Task;
using Apps.ClickUp.Models.Response.Task;
using Blackbird.Applications.Sdk.Common.Dynamic;
using Blackbird.Applications.Sdk.Common.Exceptions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.ClickUp.DataSourceHandlers.CustomField;

public abstract class BaseCustomFieldDataHandler : ClickUpInvocable
{
    private readonly string _taskId;
    protected abstract string[] Types { get; }
    
    protected BaseCustomFieldDataHandler(InvocationContext invocationContext, TaskRequest task) : base(invocationContext)
    {
        if (string.IsNullOrWhiteSpace(task.TaskId))
            throw new PluginMisconfigurationException("Please specify a task ID first");

        _taskId = task.TaskId;
    }
    
    protected async Task<IEnumerable<DataSourceItem>> GetDataAsync(DataSourceContext context)
    {
        var endpoint = $"{ApiEndpoints.Tasks}/{_taskId}";
        var request = new ClickUpRequest(endpoint, Method.Get, Creds);

        var response = await Client.ExecuteWithErrorHandling<TaskCustomFieldsConcreteResponse>(request);
        var dropdowns = response.CustomFields.Where(x => Types.Contains(x.Type)).ToList();
        
        return dropdowns
            .Where(x => x.Name.ContainsIgnoreCase(context.SearchString))
            .Select(x => new DataSourceItem(x.Id, x.Name))
            .ToList();
    }
}