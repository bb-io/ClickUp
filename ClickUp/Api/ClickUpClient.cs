using Blackbird.Applications.Sdk.Utils.Extensions.String;
using Blackbird.Applications.Sdk.Utils.RestSharp;
using ClickUp.Constants;
using ClickUp.Models.Response;
using Newtonsoft.Json;
using RestSharp;

namespace ClickUp.Api;

public class ClickUpClient : BlackBirdRestClient
{
    public ClickUpClient() : base(new RestClientOptions()
    {
        BaseUrl = Urls.ApiUrl.ToUri()
    })
    {
    }

    protected override Exception ConfigureErrorException(RestResponse response)
    {
        var error = JsonConvert.DeserializeObject<Error>(response.Content);
        return new(error.Err);
    }
}