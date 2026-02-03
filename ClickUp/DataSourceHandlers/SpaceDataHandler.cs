using Apps.ClickUp.Api;
using Apps.ClickUp.Constants;
using Apps.ClickUp.Invocables;
using Apps.ClickUp.Models.Response.Space;
using Apps.ClickUp.Utils;
using Blackbird.Applications.Sdk.Common.Dynamic;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.ClickUp.DataSourceHandlers;

public class SpaceDataHandler(InvocationContext invocationContext)
    : ClickUpInvocable(invocationContext), IAsyncDataSourceHandler
{
    public async Task<Dictionary<string, string>> GetDataAsync(DataSourceContext context,
        CancellationToken cancellationToken)
    {
        var request = new ClickUpRequest($"{ApiEndpoints.Teams}/{InvocationContext.GetTeamId()}/space", Method.Get, Creds);
        var teams = await Client.ExecuteWithErrorHandling<ListSpacesResponse>(request);

        return teams.Spaces
            .Where(x => x.Name != null)
            .Where(x => context.SearchString is null ||
                        x.Name.Contains(context.SearchString, StringComparison.OrdinalIgnoreCase))
            .Take(20)
            .ToDictionary(x => x.Id, x => x.Name);
    }
}³