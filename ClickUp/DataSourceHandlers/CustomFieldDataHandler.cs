using Apps.ClickUp.Api;
using Apps.ClickUp.Constants;
using Apps.ClickUp.Invocables;
using Apps.ClickUp.Models.Request.CustomField;
using Apps.ClickUp.Models.Response.CusomField;
using Apps.ClickUp.Models.Response.Tag;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Dynamic;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.ClickUp.DataSourceHandlers;

public class CustomFieldDataHandler : ClickUpInvocable, IAsyncDataSourceHandler
{
    private readonly CustomFieldRequest _request;

    public CustomFieldDataHandler(InvocationContext invocationContext, [ActionParameter] CustomFieldRequest request) : base(
        invocationContext)
    {
        _request = request;
    }

    public async Task<Dictionary<string, string>> GetDataAsync(DataSourceContext context,
        CancellationToken cancellationToken)
    {
        if (string.IsNullOrEmpty(_request.TeamId))
            throw new("You should specify Team ID first");

        var request = new ClickUpRequest($"{ApiEndpoints.Tasks}/{_request.TaskId}/field", Method.Get, Creds);
        var teams = await Client.ExecuteWithErrorHandling<ListCustomFieldsResponse>(request);

        return teams.Fields
            .Where(x => context.SearchString is null ||
                        x.Name.Contains(context.SearchString, StringComparison.OrdinalIgnoreCase))
            .Take(20)
            .ToDictionary(x => x.Id, x => x.Name);
    }
}