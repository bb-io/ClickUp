using Apps.ClickUp.Constants;
using Apps.ClickUp.Models.Response;
using Blackbird.Applications.Sdk.Utils.Extensions.String;
using Blackbird.Applications.Sdk.Utils.RestSharp;
using Newtonsoft.Json;
using RestSharp;

namespace Apps.ClickUp.Api;

public class ClickUpClient : BlackBirdRestClient
{
    public ClickUpClient() : base(new RestClientOptions()
    {
        BaseUrl = Urls.ApiUrl.ToUri()
    })
    {
    }
    
    public new async Task<T> ExecuteWithErrorHandling<T>(RestRequest request)
    {
        var response = await ExecuteWithErrorHandling(request);
        var json = response.Content!;

        return JsonConvert.DeserializeObject<T>(json, JsonConfig.Settings) ??
               throw new($"Could not parse {json} to {typeof(T)}");
    }

    protected override Exception ConfigureErrorException(RestResponse response)
    {
        var error = JsonConvert.DeserializeObject<Error>(response.Content);
        return new(error.Err);
    }
}