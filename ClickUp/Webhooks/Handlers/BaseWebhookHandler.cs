using Apps.ClickUp.Api;
using Apps.ClickUp.Constants;
using Apps.ClickUp.Invocables;
using Apps.ClickUp.Webhooks.Models.Payloads.Additional;
using Apps.ClickUp.Webhooks.Models.Request;
using Blackbird.Applications.Sdk.Common.Authentication;
using Blackbird.Applications.Sdk.Common.Invocation;
using Blackbird.Applications.Sdk.Common.Webhooks;
using Blackbird.Applications.Sdk.Utils.Extensions.Http;
using Blackbird.Applications.Sdk.Utils.Extensions.Sdk;
using RestSharp;

namespace Apps.ClickUp.Webhooks.Handlers;

public abstract class BaseWebhookHandler(InvocationContext invocationContext, [WebhookParameter] WebhookScopeRequest input) : ClickUpInvocable(invocationContext), IWebhookEventHandler
{
    protected abstract string EventType { get; }
    protected WebhookScopeRequest Scope { get; } = input;
    private ClickUpClient Client { get; } = new();

    public Task SubscribeAsync(IEnumerable<AuthenticationCredentialsProvider> creds, Dictionary<string, string> values)
    {
        var payload = new AddWebhookRequest()
        {
            Endpoint = values["payloadUrl"],
            Events = new List<string> { EventType }
        };

        ApplyScope(payload, Scope);

        var endpoint = $"{ApiEndpoints.Teams}/{InvocationContext.AuthenticationCredentialsProviders.Get(CredsNames.Team).Value}{ApiEndpoints.Webhooks}";
        var request = new ClickUpRequest(endpoint, Method.Post, creds)
            .WithJsonBody(payload, JsonConfig.Settings);

        return Client.ExecuteWithErrorHandling(request);
    }

    public async Task UnsubscribeAsync(IEnumerable<AuthenticationCredentialsProvider> creds, Dictionary<string, string> values)
    {
        var allWebhooks = await GetAllWebhooks(creds);
        var currentHook = allWebhooks.Webhooks
            .FirstOrDefault(x => x.Endpoint == values["payloadUrl"]);

        if (currentHook == null)
            return;

        var endpoint = $"{ApiEndpoints.Webhooks}/{currentHook.Id}";
        var request = new ClickUpRequest(endpoint, Method.Delete, creds);

        await Client.ExecuteWithErrorHandling(request);
    }

    private Task<WebhooksResponse> GetAllWebhooks(IEnumerable<AuthenticationCredentialsProvider> creds)
    {
        var endpoint = $"{ApiEndpoints.Teams}/{InvocationContext.AuthenticationCredentialsProviders.Get(CredsNames.Team).Value}{ApiEndpoints.Webhooks}";
        var request = new ClickUpRequest(endpoint, Method.Get, creds);

        return Client.ExecuteWithErrorHandling<WebhooksResponse>(request);
    }

    private void ApplyScope(AddWebhookRequest payload, WebhookScopeRequest scope)
    {
        var taskId = Normalize(scope.TaskId);
        if (!string.IsNullOrWhiteSpace(taskId))
        {
            payload.TaskId = taskId;
            return;
        }

        var listId = TryParseLong(scope.ListId);
        if (listId.HasValue)
        {
            payload.ListId = listId.Value;
            return;
        }

        var folderId = TryParseLong(scope.FolderId);
        if (folderId.HasValue)
        {
            payload.FolderId = folderId.Value;
            return;
        }

        var spaceId = TryParseLong(InvocationContext.AuthenticationCredentialsProviders.Get(CredsNames.Space).Value);
        if (spaceId.HasValue)
        {
            payload.SpaceId = spaceId.Value;
        }
    }

    private static long? TryParseLong(string? value)
        => long.TryParse(value?.Trim(), out var v) ? v : null;

    private static string? Normalize(string? value)
        => string.IsNullOrWhiteSpace(value) ? null : value.Trim();
}