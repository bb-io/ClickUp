using Apps.ClickUp.Api;
using Apps.ClickUp.Constants;
using Apps.ClickUp.Invocables;
using Apps.ClickUp.Models.Response.Space;
using Blackbird.Applications.Sdk.Common.Dynamic;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.ClickUp.DataSourceHandlers.Space;

public class SpaceDataHandler : ClickUpInvocable, IAsyncDataSourceHandler
{
    private readonly string _teamId;

    public SpaceDataHandler(InvocationContext invocationContext, string teamId) : base(invocationContext)
    {
        _teamId = teamId;
    }

    public async Task<Dictionary<string, string>> GetDataAsync(DataSourceContext context,
        CancellationToken cancellationToken)
    {
        if (string.IsNullOrEmpty(_teamId))
            throw new("You should specify Team ID first");

        var request = new ClickUpRequest($"{ApiEndpoints.Teams}/{_teamId}/space", Method.Get, Creds);
        var teams = await Client.ExecuteWithErrorHandling<ListSpacesResponse>(request);

        return teams.Spaces
            .Where(x => x.Name != null)
            .Where(x => context.SearchString is null ||
                        x.Name.Contains(context.SearchString, StringComparison.OrdinalIgnoreCase))
            .Take(20)
            .ToDictionary(x => x.Id, x => x.Name);
    }
}