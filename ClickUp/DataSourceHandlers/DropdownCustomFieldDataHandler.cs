using Apps.ClickUp.Api;
using Apps.ClickUp.Constants;
using Apps.ClickUp.Invocables;
using Apps.ClickUp.Models.Response.Task;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Dynamic;
using Blackbird.Applications.Sdk.Common.Exceptions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.ClickUp.DataSourceHandlers;

public class DropdownCustomFieldDataHandler : ClickUpInvocable, IAsyncDataSourceItemHandler
{
    private readonly string _taskId;
    
    public DropdownCustomFieldDataHandler(
        InvocationContext invocationContext, 
        [ActionParameter] string taskId) : base(invocationContext)
    {
        if (string.IsNullOrWhiteSpace(taskId))
            throw new PluginMisconfigurationException("Please specify a task ID first");

        _taskId = taskId;
    }
    
    public async Task<IEnumerable<DataSourceItem>> GetDataAsync(DataSourceContext context, CancellationToken cancellationToken)
    {
        var endpoint = $"{ApiEndpoints.Tasks}/{_taskId}";
        var request = new ClickUpRequest(endpoint, Method.Get, Creds);

        var response = await Client.ExecuteWithErrorHandling<TaskCustomFieldsConcreteResponse>(request);
        var dropdowns = response.CustomFields.Where(x => x.Type == "drop_down").ToList();
        
        return dropdowns
            .Where(x => string.IsNullOrEmpty(context.SearchString) 
                        || x.Name.Contains(context.SearchString, StringComparison.OrdinalIgnoreCase))
            .Select(x => new DataSourceItem(x.Id, x.Name))
            .ToList();
    }
}