using Blackbird.Applications.Sdk.Common.Authentication;
using Blackbird.Applications.Sdk.Common.Webhooks;
using Blackbird.Applications.Sdk.Utils.Extensions.Http;
using ClickUp.Api;
using ClickUp.Constants;
using ClickUp.Models.Request.Team;
using ClickUp.Webhooks.Models.Payloads.Additional;
using ClickUp.Webhooks.Models.Request;
using RestSharp;

namespace ClickUp.Webhooks.Handlers;

public abstract class BaseWebhookHandler : IWebhookEventHandler
{
    protected abstract string EventType { get; }
    private string TeamId { get; }
    
    private ClickUpClient Client { get; }

    public BaseWebhookHandler([WebhookParameter] TeamRequest input)
    {
        TeamId = input.TeamId;
        Client = new();
    }

    public Task SubscribeAsync(IEnumerable<AuthenticationCredentialsProvider> creds, Dictionary<string, string> values)
    {
        var payload = new AddWebhookRequest()
        {
            Endpoint = values["payloadUrl"],
            Events = new List<string> { EventType }
        };

        var endpoint = $"{ApiEndpoints.Teams}/{TeamId}{ApiEndpoints.Webhooks}";
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
        var endpoint = $"{ApiEndpoints.Teams}/{TeamId}{ApiEndpoints.Webhooks}";
        var request = new ClickUpRequest(endpoint, Method.Get, creds);
        
        return Client.ExecuteWithErrorHandling<WebhooksResponse>(request);
    }
}