using Apps.ClickUp.Api;
using Apps.ClickUp.Constants;
using Apps.ClickUp.Invocables;
using Apps.ClickUp.Models.Response.Goal;
using Blackbird.Applications.Sdk.Common.Dynamic;
using Blackbird.Applications.Sdk.Common.Invocation;
using Blackbird.Applications.Sdk.Utils.Extensions.Sdk;
using RestSharp;

namespace Apps.ClickUp.DataSourceHandlers;

public class GoalDataHandler : ClickUpInvocable, IAsyncDataSourceHandler
{
    private readonly string _teamId;

    public GoalDataHandler(InvocationContext invocationContext) : base(
        invocationContext)
    {
        _teamId = InvocationContext.AuthenticationCredentialsProviders.Get(CredsNames.Team).Value;
    }

    public async Task<Dictionary<string, string>> GetDataAsync(DataSourceContext context,
        CancellationToken cancellationToken)
    {
        if (string.IsNullOrEmpty(_teamId))
            throw new("You should specify Team ID first");

        var request = new ClickUpRequest($"{ApiEndpoints.Teams}/{_teamId}/goal", Method.Get, Creds);
        var teams = await Client.ExecuteWithErrorHandling<ListGoalsResponse>(request);

        return teams.Goals
            .Where(x => context.SearchString is null ||
                        x.Name.Contains(context.SearchString, StringComparison.OrdinalIgnoreCase))
            .Take(20)
            .ToDictionary(x => x.Id, x => x.Name);
    }
}