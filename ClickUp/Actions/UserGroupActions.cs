using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using Blackbird.Applications.Sdk.Utils.Extensions.Http;
using Blackbird.Applications.Sdk.Utils.Extensions.String;
using ClickUp.Actions.Base;
using ClickUp.Api;
using ClickUp.Constants;
using ClickUp.Models.Entities;
using ClickUp.Models.Request.Group;
using ClickUp.Models.Request.Team;
using ClickUp.Models.Response.Group;
using RestSharp;

namespace ClickUp.Actions;

[ActionList]
public class UserGroupActions : ClickUpActions
{
    public UserGroupActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }
    
    [Action("Get user groups", Description = "Get all user groups")]
    public Task<ListGroupsResponse> GetGroups([ActionParameter] ListGroupsQuery query)
    {
        var endpoint = ApiEndpoints.Groups;
        var request = new ClickUpRequest(endpoint.WithQuery(query), Method.Get, Creds);
        
        return Client.ExecuteWithErrorHandling<ListGroupsResponse>(request);
    }      
    
    [Action("Create user group", Description = "Create a new user group")]
    public Task<GroupEntity> CreateGroup(
        [ActionParameter] TeamRequest team,
        [ActionParameter] CreateGroupRequest input)
    {
        var endpoint = $"{ApiEndpoints.Teams}/{team.TeamId}{ApiEndpoints.Groups}";
        var request = new ClickUpRequest(endpoint, Method.Post, Creds)
            .WithJsonBody(input, JsonConfig.Settings);
        
        return Client.ExecuteWithErrorHandling<GroupEntity>(request);
    }  
    
    [Action("Delete user group", Description = "Delete specific user group")]
    public Task DeleteGroup([ActionParameter] GroupRequest group)
    {
        var endpoint = $"{ApiEndpoints.Groups}/{group.GroupId}";
        var request = new ClickUpRequest(endpoint, Method.Delete, Creds);
        
        return Client.ExecuteWithErrorHandling(request);
    }  
}