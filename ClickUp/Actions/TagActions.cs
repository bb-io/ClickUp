using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using Blackbird.Applications.Sdk.Utils.Extensions.Http;
using ClickUp.Actions.Base;
using ClickUp.Api;
using ClickUp.Constants;
using ClickUp.Models.Entities;
using ClickUp.Models.Request.Space;
using ClickUp.Models.Request.Tag;
using ClickUp.Models.Response.Tag;
using RestSharp;

namespace ClickUp.Actions;

[ActionList]
public class TagActions : ClickUpActions
{
    public TagActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }
    
    [Action("Get tags", Description = "Get all space tags")]
    public Task<ListTagsResponse> GetTags([ActionParameter] SpaceRequest space)
    {
        var endpoint = $"{ApiEndpoints.Spaces}/{space.SpaceId}{ApiEndpoints.Tags}";
        var request = new ClickUpRequest(endpoint, Method.Get, Creds);

        return Client.ExecuteWithErrorHandling<ListTagsResponse>(request);
    }
    
    [Action("Create tag", Description = "Create a new space tag")]
    public async Task<TagEntity> CreateTag(
        [ActionParameter] SpaceRequest space, 
        [ActionParameter] CreateTagInput input)
    {
        var endpoint = $"{ApiEndpoints.Spaces}/{space.SpaceId}{ApiEndpoints.Tags}";
        var request = new ClickUpRequest(endpoint, Method.Post, Creds)
            .WithJsonBody(new CreateTagRequest(input), JsonConfig.Settings);
        
        await Client.ExecuteWithErrorHandling(request);
        var allTags = await GetTags(space);

        return allTags.Tags.First(x => x.Name == input.Name);
    }
    
    [Action("Delete tag", Description = "Delete specific space tag")]
    public Task DeleteTag(
        [ActionParameter] SpaceRequest space, 
        [ActionParameter] TagRequest tag)
    {
        var endpoint = $"{ApiEndpoints.Spaces}/{space.SpaceId}{ApiEndpoints.Tags}/{tag.TagName}";
        var request = new ClickUpRequest(endpoint, Method.Delete, Creds);
        
        return Client.ExecuteWithErrorHandling(request);
    }
}