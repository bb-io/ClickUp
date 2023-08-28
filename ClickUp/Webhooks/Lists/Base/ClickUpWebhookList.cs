using Blackbird.Applications.Sdk.Common.Webhooks;
using ClickUp.Constants;
using Newtonsoft.Json;

namespace ClickUp.Webhooks.Lists.Base;

public abstract class ClickUpWebhookList
{
    protected Task<WebhookResponse<T>> HandleRequest<T>(WebhookRequest request) where T : class
    {
        var data = JsonConvert.DeserializeObject<T>(request.Body.ToString(), JsonConfig.Settings);
        
        return Task.FromResult(new WebhookResponse<T>
        {
            HttpResponseMessage = null,
            Result = data
        });
    }
}