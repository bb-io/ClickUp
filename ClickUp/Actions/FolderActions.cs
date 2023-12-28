using Apps.ClickUp.Actions.Base;
using Apps.ClickUp.Api;
using Apps.ClickUp.Constants;
using Apps.ClickUp.Models.Entities;
using Apps.ClickUp.Models.Request;
using Apps.ClickUp.Models.Request.Folder;
using Apps.ClickUp.Models.Request.Space;
using Apps.ClickUp.Models.Response.Folder;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using Blackbird.Applications.Sdk.Utils.Extensions.Http;
using Blackbird.Applications.Sdk.Utils.Extensions.String;
using RestSharp;

namespace Apps.ClickUp.Actions;

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
    
    [Action("Create folder", Description = "Create a new folder")]
    public Task<FolderEntity> CreateFolder(
        [ActionParameter] SpaceRequest space,
        [ActionParameter] CreateFolderRequest input)
    {
        var endpoint = $"{ApiEndpoints.Spaces}/{space.SpaceId}{ApiEndpoints.Folders}";
        var request = new ClickUpRequest(endpoint, Method.Post, Creds)
            .WithJsonBody(input, JsonConfig.Settings);
        
        return Client.ExecuteWithErrorHandling<FolderEntity>(request);
    }
    
    [Action("Get folder", Description = "Get specific folder details")]
    public Task<FolderEntity> GetFolder([ActionParameter] FolderRequest folder)
    {
        var endpoint = $"{ApiEndpoints.Folders}/{folder.FolderId}";
        var request = new ClickUpRequest(endpoint, Method.Get, Creds);
        
        return Client.ExecuteWithErrorHandling<FolderEntity>(request);
    }
    
    [Action("Delete folder", Description = "Delete specific folder")]
    public Task DeleteFolder([ActionParameter] FolderRequest folder)
    {
        var endpoint = $"{ApiEndpoints.Folders}/{folder.FolderId}";
        var request = new ClickUpRequest(endpoint, Method.Delete, Creds);
        
        return Client.ExecuteWithErrorHandling(request);
    }
}