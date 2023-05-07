using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Authentication;
using ClickUp.InputParameters;
using ClickUp.Models;
using ClickUp.Requests;
using ClickUp.Responses;
using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClickUp
{
    [ActionList]
    public class Actions
    {
        [Action("Get teams", Description = "Get all teams for this user connection")]
        public TeamResponse GetTeams(IEnumerable<AuthenticationCredentialsProvider> authenticationCredentialsProviders)
        {
            var client = new ClickUpClient();
            var request = new ClickUpRequest("/team", Method.Get, authenticationCredentialsProviders);
            return client.Get<TeamResponse>(request) ?? new TeamResponse();
        }

        [Action("Get spaces", Description = "Get all spaces given a specific team")]
        public SpaceResponse GetSpaces(IEnumerable<AuthenticationCredentialsProvider> authenticationCredentialsProviders, [ActionParameter] string teamId)
        {
            var client = new ClickUpClient();
            var request = new ClickUpRequest($"/team/{teamId}/space", Method.Get, authenticationCredentialsProviders);
            return client.Get<SpaceResponse>(request) ?? new SpaceResponse();
        }

        [Action("Get folders", Description = "Get all folders given a specific space")]
        public FolderResponse GetFolders(IEnumerable<AuthenticationCredentialsProvider> authenticationCredentialsProviders, [ActionParameter] string spaceId)
        {
            var client = new ClickUpClient();
            var request = new ClickUpRequest($"/space/{spaceId}/folder", Method.Get, authenticationCredentialsProviders);
            return client.Get<FolderResponse>(request) ?? new FolderResponse();
        }

        [Action("Get lists from space", Description = "Get all lists given a specific space")]
        public ListResponse GetListsFromSpace(IEnumerable<AuthenticationCredentialsProvider> authenticationCredentialsProviders, [ActionParameter] string spaceId)
        {
            var client = new ClickUpClient();
            var request = new ClickUpRequest($"/space/{spaceId}/list", Method.Get, authenticationCredentialsProviders);
            return client.Get<ListResponse>(request) ?? new ListResponse();
        }

        [Action("Get lists from folder", Description = "Get all lists given a specific folder")]
        public ListResponse GetListsFromFolder(IEnumerable<AuthenticationCredentialsProvider> authenticationCredentialsProviders, [ActionParameter] string folderId)
        {
            var client = new ClickUpClient();
            var request = new ClickUpRequest($"/folder/{folderId}/list", Method.Get, authenticationCredentialsProviders);
            return client.Get<ListResponse>(request) ?? new ListResponse();
        }

        [Action("Get tasks from list", Description = "Get all tasks given a specific list")]
        public TaskResponse GetTasksFromList(IEnumerable<AuthenticationCredentialsProvider> authenticationCredentialsProviders, [ActionParameter] string listId)
        {
            var client = new ClickUpClient();
            var request = new ClickUpRequest($"/list/{listId}/task", Method.Get, authenticationCredentialsProviders);
            return client.Get<TaskResponse>(request) ?? new TaskResponse();
        }

        [Action("Get task", Description = "Get the details of a specific task")]
        public TaskWithStatus GetTasks(IEnumerable<AuthenticationCredentialsProvider> authenticationCredentialsProviders, [ActionParameter] string taskId)
        {
            var client = new ClickUpClient();
            var request = new ClickUpRequest($"/task/{taskId}", Method.Get, authenticationCredentialsProviders);
            var response = client.Get<Models.Task>(request);
            return TaskWithStatus.FromTask(response);
        }

        [Action("Create task", Description = "Create a new task")]
        public Models.Task CreateTask(IEnumerable<AuthenticationCredentialsProvider> authenticationCredentialsProviders, [ActionParameter] NewTask task)
        {
            var client = new ClickUpClient();
            var request = new ClickUpRequest($"/list/{task.ListId}/task", Method.Post, authenticationCredentialsProviders);
            request.AddJsonBody(new
            {
                Name = task.Name,
                Description = task.Description,
            });
            return client.Post<Models.Task>(request);
        }

        [Action("Create task attachment", Description = "Adds files as an attachment to a task")]
        public AttachmentResponse CreateAttachment(IEnumerable<AuthenticationCredentialsProvider> authenticationCredentialsProviders, [ActionParameter] Attachment attachment)
        {
            var client = new ClickUpClient();
            var request = new ClickUpRequest($"/task/{attachment.TaskId}/attachment", Method.Post, authenticationCredentialsProviders);
            request.AddFile("attachment", attachment.File, attachment.FileName);
            return client.Post<AttachmentResponse>(request);
        }
    }
}