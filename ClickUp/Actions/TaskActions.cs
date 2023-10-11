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
using ClickUp.Models.Request.List;
using ClickUp.Models.Request.Task;
using ClickUp.Models.Response.Task;
using RestSharp;

namespace ClickUp.Actions;

[ActionList]
public class TaskActions : ClickUpActions
{
    public TaskActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }
    
    [Action("Get tasks", Description = "Get all tasks given a specific list")]
    public Task<ListTasksResponse> GetTasksFromList([ActionParameter] ListRequest list)
    {
        var endpoint = $"{ApiEndpoints.Lists}/{list.ListId}{ApiEndpoints.Tasks}";
        var request = new ClickUpRequest(endpoint, Method.Get, Creds);
        
        return Client.ExecuteWithErrorHandling<ListTasksResponse>(request);
    }

    [Action("Get task", Description = "Get the details of a specific task")]
    public Task<TaskEntity> GetTask([ActionParameter] TaskRequest task)
    {
        var endpoint = $"{ApiEndpoints.Tasks}/{task.TaskId}";
        var request = new ClickUpRequest(endpoint, Method.Get, Creds);
        
        return Client.ExecuteWithErrorHandling<TaskEntity>(request);
    }

    [Action("Create task", Description = "Create a new task")]
    public Task<TaskEntity> CreateTask(
        [ActionParameter] ListRequest list,
        [ActionParameter] CreateRequestQuery query,
        [ActionParameter] CreateTaskRequest requestBody)
    {
        var endpoint = $"{ApiEndpoints.Lists}/{list.ListId}{ApiEndpoints.Tasks}";
        var request = new ClickUpRequest(endpoint.WithQuery(query), Method.Post, Creds)
            .WithJsonBody(requestBody, JsonConfig.Settings);
        
        return Client.ExecuteWithErrorHandling<TaskEntity>(request);
    }
    
    [Action("Delete task", Description = "Delete specific task")]
    public Task DeleteTask(
        [ActionParameter] TaskRequest task)
    {
        var endpoint = $"{ApiEndpoints.Tasks}/{task.TaskId}";
        var request = new ClickUpRequest(endpoint, Method.Delete, Creds);
        
        return Client.ExecuteWithErrorHandling(request);
    }
}