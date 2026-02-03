using Apps.ClickUp.Api;
using Apps.ClickUp.Constants;
using Apps.ClickUp.Invocables;
using Apps.ClickUp.Models.Response.Folder;
using Apps.ClickUp.Utils;
using Blackbird.Applications.Sdk.Common.Dynamic;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.ClickUp.DataSourceHandlers;

public class FolderDataHandler(InvocationContext invocationContext)
    : ClickUpInvocable(invocationContext), IAsyncDataSourceHandler
{
    public async Task<Dictionary<string, string>> GetDataAsync(DataSourceContext context,
        CancellationToken cancellationToken)
    {
        var request = new ClickUpRequest($"{ApiEndpoints.Spaces}/{InvocationContext.GetSpaceId()}/folder", Method.Get, Creds);
        var teams = await Client.ExecuteWithErrorHandling<ListFoldersResponse>(request);

        return teams.Folders
            .Where(x => context.SearchString is null ||
                        x.Name.Contains(context.SearchString, StringComparison.OrdinalIgnoreCase))
            .Take(20)
            .ToDictionary(x => x.Id, x => x.Name);
    }
}