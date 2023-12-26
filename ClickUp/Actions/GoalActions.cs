using Apps.ClickUp.Actions.Base;
using Apps.ClickUp.Api;
using Apps.ClickUp.Constants;
using Apps.ClickUp.Models.Entities;
using Apps.ClickUp.Models.Request.Goal;
using Apps.ClickUp.Models.Request.Team;
using Apps.ClickUp.Models.Response.Goal;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using Blackbird.Applications.Sdk.Utils.Extensions.Http;
using Blackbird.Applications.Sdk.Utils.Extensions.String;
using RestSharp;

namespace Apps.ClickUp.Actions;

[ActionList]
public class GoalActions : ClickUpActions
{
    public GoalActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }
    
    [Action("Get goals", Description = "Get all goals")]
    public Task<ListGoalsResponse> GetGoals(
        [ActionParameter] TeamRequest team,
        [ActionParameter] ListGoalsQuery query)
    {
        var endpoint = $"{ApiEndpoints.Teams}/{team.TeamId}{ApiEndpoints.Goals}";
        var request = new ClickUpRequest(endpoint.WithQuery(query), Method.Get, Creds);
        
        return Client.ExecuteWithErrorHandling<ListGoalsResponse>(request);
    }
    
    [Action("Create goal", Description = "Create a new goal")]
    public async Task<GoalEntity> CreateGoal(
        [ActionParameter] TeamRequest team,
        [ActionParameter] CreateGoalRequest input)
    {
        var endpoint = $"{ApiEndpoints.Teams}/{team.TeamId}{ApiEndpoints.Goals}";
        var request = new ClickUpRequest(endpoint, Method.Post, Creds)
            .WithJsonBody(input, JsonConfig.Settings);
        
        var response = await Client.ExecuteWithErrorHandling<GoalResponse>(request);
        return response.Goal;
    }
    
    [Action("Get goal", Description = "Get specific goal details")]
    public async Task<GoalEntity> GetGoal([ActionParameter] GoalRequest goal)
    {
        var endpoint = $"{ApiEndpoints.Goals}/{goal.GoalId}";
        var request = new ClickUpRequest(endpoint, Method.Get, Creds);
        
        var response = await Client.ExecuteWithErrorHandling<GoalResponse>(request);
        return response.Goal;
    }
    
    [Action("Delete goal", Description = "Delete specific goal")]
    public Task DeleteGoal([ActionParameter] GoalRequest goal)
    {
        var endpoint = $"{ApiEndpoints.Goals}/{goal.GoalId}";
        var request = new ClickUpRequest(endpoint, Method.Delete, Creds);
        
        return Client.ExecuteWithErrorHandling(request);
    }
    
    [Action("Create key result", Description = "Create goal key result")]
    public async Task<KeyResultEntity> CreateKeyResult(
        [ActionParameter] GoalRequest goal,
        [ActionParameter] CreateKeyResultRequest input)
    {
        var endpoint = $"{ApiEndpoints.Goals}/{goal.GoalId}{ApiEndpoints.KeyResults}";
        var request = new ClickUpRequest(endpoint, Method.Post, Creds)
            .WithJsonBody(input, JsonConfig.Settings);
        
        var response = await Client.ExecuteWithErrorHandling<KeyResultResponse>(request);
        return response.KeyResult;
    }
}