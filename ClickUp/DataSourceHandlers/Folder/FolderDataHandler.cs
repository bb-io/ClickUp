using Apps.ClickUp.Api;
using Apps.ClickUp.Constants;
using Apps.ClickUp.Invocables;
using Apps.ClickUp.Models.Response.Folder;
using Blackbird.Applications.Sdk.Common.Dynamic;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.ClickUp.DataSourceHandlers.Folder;

public class FolderDataHandler : ClickUpInvocable, IAsyncDataSourceHandler
{
    private readonly string _spaceId;

    public FolderDataHandler(InvocationContext invocationContext, string spaceId) : base(invocationContext)
    {
        _spaceId = spaceId;
    }

    public async Task<Dictionary<string, string>> GetDataAsync(DataSourceContext context,
        CancellationToken cancellationToken)
    {
        if (string.IsNullOrEmpty(_spaceId))
            throw new("You should specify Space ID first");

        var request = new ClickUpRequest($"{ApiEndpoints.Spaces}/{_spaceId}/folder", Method.Get, Creds);
        var teams = await Client.ExecuteWithErrorHandling<ListFoldersResponse>(request);

        return teams.Folders
            .Where(x => context.SearchString is null ||
                        x.Name.Contains(context.SearchString, StringComparison.OrdinalIgnoreCase))
            .Take(20)
            .ToDictionary(x => x.Id, x => x.Name);
    }
}