using Apps.ClickUp.Actions.Base;
using Apps.ClickUp.Api;
using Apps.ClickUp.Constants;
using Apps.ClickUp.Models.Response.Team;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.ClickUp.Actions;

[ActionList]
public class TeamActions : ClickUpActions
{
    public TeamActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }
    
    [Action("Get teams", Description = "Get all teams for this user connection")]
    public Task<ListTeamsResponse> GetTeams()
    {
        var request = new ClickUpRequest(ApiEndpoints.Teams, Method.Get, Creds);
        return Client.ExecuteWithErrorHandling<ListTeamsResponse>(request);
    }    
}