using Apps.ClickUp.Api;
using Apps.ClickUp.Constants;
using Apps.ClickUp.Invocables;
using Apps.ClickUp.Models.Request.Tag;
using Apps.ClickUp.Models.Response.Tag;
using Apps.ClickUp.Utils;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Dynamic;
using Blackbird.Applications.Sdk.Common.Invocation;
using Blackbird.Applications.Sdk.Utils.Extensions.Sdk;
using RestSharp;

namespace Apps.ClickUp.DataSourceHandlers;

public class TagDataHandler : ClickUpInvocable, IAsyncDataSourceHandler
{
    public TagDataHandler(InvocationContext invocationContext) : base(
        invocationContext)
    {
    }

    public async Task<Dictionary<string, string>> GetDataAsync(DataSourceContext context,
        CancellationToken cancellationToken)
    {
        var request = new ClickUpRequest($"{ApiEndpoints.Spaces}/{InvocationContext.GetSpaceId()}/tag", Method.Get, Creds);
        var teams = await Client.ExecuteWithErrorHandling<ListTagsResponse>(request);

        return teams.Tags
            .Where(x => context.SearchString is null ||
                        x.Name.Contains(context.SearchString, StringComparison.OrdinalIgnoreCase))
            .Take(20)
            .ToDictionary(x => x.Name, x => x.Name);
    }
}