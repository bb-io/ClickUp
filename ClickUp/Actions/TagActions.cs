using Apps.ClickUp.Actions.Base;
using Apps.ClickUp.Api;
using Apps.ClickUp.Constants;
using Apps.ClickUp.Models.Entities;
using Apps.ClickUp.Models.Request.Space;
using Apps.ClickUp.Models.Request.Tag;
using Apps.ClickUp.Models.Response.Tag;
using Apps.ClickUp.Utils;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using Blackbird.Applications.Sdk.Utils.Extensions.Http;
using Blackbird.Applications.Sdk.Utils.Extensions.Sdk;
using RestSharp;

namespace Apps.ClickUp.Actions;

[ActionList("Tag")]
public class TagActions : ClickUpActions
{
    public TagActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Search tags", Description = "Get all space tags")]
    public Task<ListTagsResponse> GetTags()
    {
        var endpoint = $"{ApiEndpoints.Spaces}/{InvocationContext.GetSpaceId()}{ApiEndpoints.Tags}";
        var request = new ClickUpRequest(endpoint, Method.Get, Creds);

        return Client.ExecuteWithErrorHandling<ListTagsResponse>(request);
    }

    [Action("Create tag", Description = "Create a new space tag")]
    public async Task<TagEntity> CreateTag([ActionParameter] CreateTagInput input)
    {
        var endpoint = $"{ApiEndpoints.Spaces}/{InvocationContext.GetSpaceId()}{ApiEndpoints.Tags}";
        var request = new ClickUpRequest(endpoint, Method.Post, Creds)
            .WithJsonBody(new CreateTagRequest(input), JsonConfig.Settings);

        await Client.ExecuteWithErrorHandling(request);
        var allTags = await GetTags();

        return allTags.Tags.First(x => x.Name == input.Name);
    }

    [Action("Delete tag", Description = "Delete specific space tag")]
    public Task DeleteTag([ActionParameter] TagRequest tag)
    {
        var endpoint = $"{ApiEndpoints.Spaces}/{InvocationContext.GetSpaceId()}{ApiEndpoints.Tags}/{tag.TagName}";
        var request = new ClickUpRequest(endpoint, Method.Delete, Creds);

        return Client.ExecuteWithErrorHandling(request);
    }
}