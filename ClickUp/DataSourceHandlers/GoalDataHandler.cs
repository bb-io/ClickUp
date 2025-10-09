using Apps.ClickUp.Api;
using Apps.ClickUp.Constants;
using Apps.ClickUp.Invocables;
using Apps.ClickUp.Models.Request.Goal;
using Apps.ClickUp.Models.Response.Goal;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Dynamic;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.ClickUp.DataSourceHandlers;

public class GoalDataHandler : ClickUpInvocable, IAsyncDataSourceHandler
{
    private readonly GoalRequest _request;

    public GoalDataHandler(InvocationContext invocationContext, [ActionParameter] GoalRequest request) : base(
        invocationContext)
    {
        _request = request;
    }

    public async Task<Dictionary<string, string>> GetDataAsync(DataSourceContext context,
        CancellationToken cancellationToken)
    {
        if (string.IsNullOrEmpty(_request.TeamId))
            throw new("You should specify Team ID first");

        var request = new ClickUpRequest($"{ApiEndpoints.Teams}/{_request.TeamId}/goal", Method.Get, Creds);
        var teams = await Client.ExecuteWithErrorHandling<ListGoalsResponse>(request);

        return teams.Goals
            .Where(x => context.SearchString is null ||
                        x.Name.Contains(context.SearchString, StringComparison.OrdinalIgnoreCase))
            .Take(20)
            .ToDictionary(x => x.Id, x => x.Name);
    }
}