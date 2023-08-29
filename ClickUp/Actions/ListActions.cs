using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using Blackbird.Applications.Sdk.Utils.Extensions.Http;
using Blackbird.Applications.Sdk.Utils.Extensions.String;
using ClickUp.Actions.Base;
using ClickUp.Api;
using ClickUp.Constants;
using ClickUp.Models.Entities;
using ClickUp.Models.Request;
using ClickUp.Models.Request.Folder;
using ClickUp.Models.Request.List;
using ClickUp.Models.Request.Space;
using ClickUp.Models.Response.List;
using RestSharp;

namespace ClickUp.Actions;

[ActionList]
public class ListActions : ClickUpActions
{
    public ListActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get lists from space", Description = "Get all lists given a specific space")]
    public Task<ListListsResponse> GetListsFromSpace(
        [ActionParameter] SpaceRequest space,
        [ActionParameter] ListQuery query)
    {
        var endpoint = $"{ApiEndpoints.Spaces}/{space.SpaceId}{ApiEndpoints.Lists}";
        var request = new ClickUpRequest(endpoint.WithQuery(query), Method.Get, Creds);
        
        return Client.ExecuteWithErrorHandling<ListListsResponse>(request);
    }

    [Action("Get lists from folder", Description = "Get all lists given a specific folder")]
    public Task<ListListsResponse> GetListsFromFolder(
        [ActionParameter] FolderRequest folder,
        [ActionParameter] ListQuery query)
    {
        var endpoint = $"{ApiEndpoints.Folders}/{folder.FolderId}{ApiEndpoints.Lists}";
        var request = new ClickUpRequest(endpoint.WithQuery(query), Method.Get, Creds);
        
        return Client.ExecuteWithErrorHandling<ListListsResponse>(request);
    }

    [Action("Create folder list", Description = "Create a new folder list")]
    public Task<ListEntity> CreateFolderList(
        [ActionParameter] FolderRequest folder,
        [ActionParameter] CreateListRequest body)
    {
        var endpoint = $"{ApiEndpoints.Folders}/{folder.FolderId}{ApiEndpoints.Lists}";
        var request = new ClickUpRequest(endpoint, Method.Post, Creds)
            .WithJsonBody(body, JsonConfig.Settings);
        
        return Client.ExecuteWithErrorHandling<ListEntity>(request);
    }

    [Action("Create space list", Description = "Create a new space list")]
    public Task<ListEntity> CreateSpaceList(
        [ActionParameter] SpaceRequest space,
        [ActionParameter] CreateListRequest body)
    {
        var endpoint = $"{ApiEndpoints.Spaces}/{space.SpaceId}{ApiEndpoints.Lists}";
        var request = new ClickUpRequest(endpoint, Method.Post, Creds)
            .WithJsonBody(body, JsonConfig.Settings);
        
        return Client.ExecuteWithErrorHandling<ListEntity>(request);
    }

    [Action("Delete list", Description = "Delete specific list")]
    public Task DeleteList(
        [ActionParameter] ListRequest list)
    {
        var endpoint = $"{ApiEndpoints.Lists}/{list.ListId}";
        var request = new ClickUpRequest(endpoint, Method.Delete, Creds);
        
        return Client.ExecuteWithErrorHandling(request);
    }
}