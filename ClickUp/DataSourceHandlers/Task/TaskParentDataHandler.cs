using Apps.ClickUp.Api;
using Apps.ClickUp.Constants;
using Apps.ClickUp.Invocables;
using Apps.ClickUp.Models.Request.Task;
using Apps.ClickUp.Models.Response.Task;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Dynamic;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.ClickUp.DataSourceHandlers.Task;

public class TaskParentDataHandler : ClickUpInvocable, IAsyncDataSourceHandler
{
    private readonly UpdateTaskRequest _request;

    public TaskParentDataHandler(InvocationContext invocationContext, [ActionParameter] UpdateTaskRequest request)
        : base(invocationContext)
    {
        _request = request;
    }

    public async Task<Dictionary<string, string>> GetDataAsync(DataSourceContext context,
        CancellationToken cancellationToken)
    {
        if (string.IsNullOrEmpty(_request.ListId))
            throw new("You should specify List ID first");

        var request = new ClickUpRequest($"{ApiEndpoints.Lists}/{_request.ListId}/task", Method.Get, Creds);
        var tasks = await Client.ExecuteWithErrorHandling<ListTasksResponse>(request);

        return tasks.Tasks
            .Where(x => x.Id != _request.TaskId)
            .Where(x => context.SearchString is null ||
                        x.Name.Contains(context.SearchString, StringComparison.OrdinalIgnoreCase))
            .Take(20)
            .ToDictionary(x => x.Id, x => x.Name);
    }
}
