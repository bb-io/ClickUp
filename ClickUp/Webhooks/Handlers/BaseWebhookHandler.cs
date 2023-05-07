using Blackbird.Applications.Sdk.Common.Authentication;
using Blackbird.Applications.Sdk.Common.Webhooks;
using ClickUp.Models;
using ClickUp.Webhooks.Responses;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = System.Threading.Tasks.Task;

namespace ClickUp.Webhooks.Handlers
{
    public class BaseWebhookHandler : IWebhookEventHandler
    {
        private string _event;

        public BaseWebhookHandler(string @event)
        {
            _event = @event;
        }

        public async Task SubscribeAsync(IEnumerable<AuthenticationCredentialsProvider> authenticationCredentialsProviders, Dictionary<string, string> values)
        {
            var teamId = authenticationCredentialsProviders.First(p => p.KeyName == "teamId").Value;
            var client = new ClickUpClient();
            var request = new ClickUpRequest($"/team/{teamId}/webhook", Method.Post, authenticationCredentialsProviders);
            request.AddJsonBody(new
            {
                endpoint = values["payloadUrl"],
                events = new List<string> { _event }
            });
            client.Post(request);
        }

        public async Task UnsubscribeAsync(IEnumerable<AuthenticationCredentialsProvider> authenticationCredentialsProviders, Dictionary<string, string> values)
        {
            var teamId = authenticationCredentialsProviders.First(p => p.KeyName == "teamId").Value;
            var client = new ClickUpClient();
            var request = new ClickUpRequest($"/team/{teamId}/webhook", Method.Get, authenticationCredentialsProviders);
            var webhooks = client.Get<WebhooksResponse>(request);
            var currentHookId = webhooks.Webhooks.FirstOrDefault(x => x.Events.Contains(_event))?.Id;
            if (currentHookId == null)
                return;

            var deleteRequest = new ClickUpRequest($"/webhook/{currentHookId}", Method.Delete, authenticationCredentialsProviders);
            client.Delete(deleteRequest);
        }
    }
}
