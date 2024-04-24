using Apps.ClickUp.Api;
using Apps.ClickUp.Constants;
using Apps.ClickUp.Invocables;
using Apps.ClickUp.Models.Response.List;
using Blackbird.Applications.Sdk.Common.Dynamic;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.ClickUp.DataSourceHandlers.List;

public class ListDataHandler : ClickUpInvocable, IAsyncDataSourceHandler
{
    private readonly string _folderId;

    public ListDataHandler(InvocationContext invocationContext, string folderId) : base(invocationContext)
    {
        _folderId = folderId;
    }

    public async Task<Dictionary<string, string>> GetDataAsync(DataSourceContext context,
        CancellationToken cancellationToken)
    {
        if (string.IsNullOrEmpty(_folderId))
            throw new("You should specify Folder ID first");
        
        var request = new ClickUpRequest($"{ApiEndpoints.Folders}/{_folderId}/list", Method.Get, Creds);
        var teams = await Client.ExecuteWithErrorHandling<ListListsResponse>(request);

        return teams.Lists
            .Where(x => context.SearchString is null ||
                        x.Name.Contains(context.SearchString, StringComparison.OrdinalIgnoreCase))
            .Take(20)
            .ToDictionary(x => x.Id, x => x.Name);
    }
}