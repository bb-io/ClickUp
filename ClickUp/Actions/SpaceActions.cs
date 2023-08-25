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
using ClickUp.Models.Request.Space;
using ClickUp.Models.Request.Team;
using ClickUp.Models.Response.Space;
using RestSharp;

namespace ClickUp.Actions;

[ActionList]
public class SpaceActions : ClickUpActions
{
    public SpaceActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get spaces", Description = "Get all spaces given a specific team")]
    public Task<ListSpacesResponse> GetSpaces(
        [ActionParameter] TeamRequest team,
        [ActionParameter] ListQuery query)
    {
        var endpoint = $"{ApiEndpoints.Teams}/{team.TeamId}{ApiEndpoints.Spaces}";
        var request = new ClickUpRequest(endpoint.WithQuery(query), Method.Get, Creds);

        return Client.ExecuteWithErrorHandling<ListSpacesResponse>(request);
    }
    
    [Action("Create space", Description = "Create a new space")]
    public Task<SpaceEntity> CreateSpace(
        [ActionParameter] TeamRequest team,
        [ActionParameter] CreateSpaceRequest input)
    {
        var endpoint = $"{ApiEndpoints.Teams}/{team.TeamId}{ApiEndpoints.Spaces}";
        var request = new ClickUpRequest(endpoint, Method.Post, Creds)
            .WithJsonBody(input, JsonConfig.Settings);

        return Client.ExecuteWithErrorHandling<SpaceEntity>(request);
    }    
    
    [Action("Update space", Description = "Update specific space")]
    public Task<SpaceEntity> UpdateSpace(
        [ActionParameter] SpaceRequest space,
        [ActionParameter] UpdateSpaceRequest input)
    {
        var endpoint = $"{ApiEndpoints.Spaces}/{space.SpaceId}";
        var request = new ClickUpRequest(endpoint, Method.Put, Creds)
            .WithJsonBody(input, JsonConfig.Settings);
    
        return Client.ExecuteWithErrorHandling<SpaceEntity>(request);
    }    
    
    [Action("Get space", Description = "Get details of a specific space")]
    public Task<SpaceEntity> GetSpace(
        [ActionParameter] SpaceRequest space)
    {
        var endpoint = $"{ApiEndpoints.Spaces}/{space.SpaceId}";
        var request = new ClickUpRequest(endpoint, Method.Get, Creds);

        return Client.ExecuteWithErrorHandling<SpaceEntity>(request);
    }
    
    [Action("Delete space", Description = "Delete specific space")]
    public Task DeleteSpace(
        [ActionParameter] SpaceRequest space)
    {
        var endpoint = $"{ApiEndpoints.Spaces}/{space.SpaceId}";
        var request = new ClickUpRequest(endpoint, Method.Delete, Creds);

        return Client.ExecuteWithErrorHandling(request);
    }
}