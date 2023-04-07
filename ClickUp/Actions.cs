using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Authentication;
using ClickUp.InputParameters;
using ClickUp.Requests;
using ClickUp.Responses;
using RestSharp;
using System.Collections.Generic;

namespace ClickUp
{
    [ActionList]
    public class Actions
    {
        [Action("Get teams", Description = "Get all teams for this user connection")]
        public TeamResponse GetTeams(AuthenticationCredentialsProvider authenticationCredentialsProvider)
        {
            var client = new ClickUpClient();
            var request = new ClickUpRequest("/team", Method.Get, authenticationCredentialsProvider.Value);
            return client.Get<TeamResponse>(request) ?? new TeamResponse();
        }

        [Action("Get spaces", Description = "Get all spaces given a specific team")]
        public SpaceResponse GetSpaces(AuthenticationCredentialsProvider authenticationCredentialsProvider, [ActionParameter] string teamId)
        {
            var client = new ClickUpClient();
            var request = new ClickUpRequest($"/team/{teamId}/space", Method.Get, authenticationCredentialsProvider.Value);
            return client.Get<SpaceResponse>(request) ?? new SpaceResponse();
        }

        [Action("Get folders", Description = "Get all folders given a specific space")]
        public FolderResponse GetFolders(AuthenticationCredentialsProvider authenticationCredentialsProvider, [ActionParameter] string spaceId)
        {
            var client = new ClickUpClient();
            var request = new ClickUpRequest($"/space/{spaceId}/folder", Method.Get, authenticationCredentialsProvider.Value);
            return client.Get<FolderResponse>(request) ?? new FolderResponse();
        }

        [Action("Get lists from space", Description = "Get all lists given a specific space")]
        public ListResponse GetListsFromSpace(AuthenticationCredentialsProvider authenticationCredentialsProvider, [ActionParameter] string spaceId)
        {
            var client = new ClickUpClient();
            var request = new ClickUpRequest($"/space/{spaceId}/list", Method.Get, authenticationCredentialsProvider.Value);
            return client.Get<ListResponse>(request) ?? new ListResponse();
        }

        [Action("Get lists from folder", Description = "Get all lists given a specific folder")]
        public ListResponse GetListsFromFolder(AuthenticationCredentialsProvider authenticationCredentialsProvider, [ActionParameter] string folderId)
        {
            var client = new ClickUpClient();
            var request = new ClickUpRequest($"/folder/{folderId}/list", Method.Get, authenticationCredentialsProvider.Value);
            return client.Get<ListResponse>(request) ?? new ListResponse();
        }

        [Action("Get tasks from list", Description = "Get all tasks given a specific list")]
        public TaskResponse GetTasksFromList(AuthenticationCredentialsProvider authenticationCredentialsProvider, [ActionParameter] string listId)
        {
            var client = new ClickUpClient();
            var request = new ClickUpRequest($"/list/{listId}/task", Method.Get, authenticationCredentialsProvider.Value);
            return client.Get<TaskResponse>(request) ?? new TaskResponse();
        }

        [Action("Get task", Description = "Get the details of a specific task")]
        public Models.Task GetTasks(AuthenticationCredentialsProvider authenticationCredentialsProvider, [ActionParameter] string taskId)
        {
            var client = new ClickUpClient();
            var request = new ClickUpRequest($"/task/{taskId}", Method.Get, authenticationCredentialsProvider.Value);
            return client.Get<Models.Task>(request);
        }

        [Action("Create task", Description = "Create a new task")]
        public Models.Task CreateTask(AuthenticationCredentialsProvider authenticationCredentialsProvider, [ActionParameter] NewTask task)
        {
            var client = new ClickUpClient();
            var request = new ClickUpRequest($"/list/{task.ListId}/task", Method.Post, authenticationCredentialsProvider.Value);
            request.AddJsonBody(new
            {
                Name = task.Name,
                Description = task.Description,
            });
            return client.Post<Models.Task>(request);
        }
    }
}