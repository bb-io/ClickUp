using Apps.ClickUp.Api;
using Apps.ClickUp.Constants;
using Apps.ClickUp.Invocables;
using Apps.ClickUp.Models.Entities;
using Apps.ClickUp.Models.Request.Task;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Dynamic;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.ClickUp.DataSourceHandlers.Task;

public class TaskStatusDataHandler : ClickUpInvocable, IAsyncDataSourceHandler
{
    private readonly UpdateTaskRequest _request;

    public TaskStatusDataHandler(InvocationContext invocationContext, [ActionParameter] UpdateTaskRequest request)
        : base(invocationContext)
    {
        _request = request;
    }

    public async Task<Dictionary<string, string>> GetDataAsync(DataSourceContext context,
        CancellationToken cancellationToken)
    {
        if (string.IsNullOrEmpty(_request.ListId))
            throw new("You should specify List ID first");

        var request = new ClickUpRequest($"{ApiEndpoints.Lists}/{_request.ListId}", Method.Get, Creds);
        var list = await Client.ExecuteWithErrorHandling<ListEntity>(request);

        return list.Statuses
            .Where(x => context.SearchString is null ||
                        x.Status.Contains(context.SearchString, StringComparison.OrdinalIgnoreCase))
            .Take(20)
            .ToDictionary(x => x.Status, x => x.Status);
    }
}
