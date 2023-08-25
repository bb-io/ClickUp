using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using Blackbird.Applications.Sdk.Utils.Extensions.String;
using ClickUp.Actions.Base;
using ClickUp.Api;
using ClickUp.Constants;
using ClickUp.Models.Request;
using ClickUp.Models.Request.Space;
using ClickUp.Models.Response.Folder;
using RestSharp;

namespace ClickUp.Actions;

[ActionList]
public class FolderActions : ClickUpActions
{
    public FolderActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }
    
    [Action("Get folders", Description = "Get all folders given a specific space")]
    public Task<ListFoldersResponse> GetFolders(
        [ActionParameter] SpaceRequest space,
        [ActionParameter] ListQuery query)
    {
        var endpoint = $"{ApiEndpoints.Spaces}/{space.SpaceId}{ApiEndpoints.Folders}";
        var request = new ClickUpRequest(endpoint.WithQuery(query), Method.Get, Creds);
        
        return Client.ExecuteWithErrorHandling<ListFoldersResponse>(request);
    }
}