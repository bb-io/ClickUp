using Apps.ClickUp.Api;
using Apps.ClickUp.Constants;
using Apps.ClickUp.Invocables;
using Apps.ClickUp.Models.Response.Task;
using Blackbird.Applications.Sdk.Common.Dynamic;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.ClickUp.DataSourceHandlers.Task;

public class TaskDataHandler: ClickUpInvocable, IAsyncDataSourceHandler
{
    private readonly string _listId;

    public TaskDataHandler(InvocationContext invocationContext, string listId) : base(invocationContext)
    {
        _listId = listId;
    }

    public async Task<Dictionary<string, string>> GetDataAsync(DataSourceContext context,
        CancellationToken cancellationToken)
    {
        if (string.IsNullOrEmpty(_listId))
            throw new("You should specify List ID first");

        var request = new ClickUpRequest($"{ApiEndpoints.Lists}/{_listId}/task", Method.Get, Creds);
        var teams = await Client.ExecuteWithErrorHandling<ListTasksResponse>(request);

        return teams.Tasks
            .Where(x => context.SearchString is null ||
                        x.Name.Contains(context.SearchString, StringComparison.OrdinalIgnoreCase))
            .Take(20)
            .ToDictionary(x => x.Id, x => x.Name);
    }
}