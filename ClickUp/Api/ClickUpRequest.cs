using Blackbird.Applications.Sdk.Common.Authentication;
using Blackbird.Applications.Sdk.Utils.Extensions.Sdk;
using Blackbird.Applications.Sdk.Utils.RestSharp;
using ClickUp.Constants;
using RestSharp;

namespace ClickUp.Api;

public class ClickUpRequest : BlackBirdRestRequest
{
    public ClickUpRequest(string endpoint, Method method, IEnumerable<AuthenticationCredentialsProvider> creds) : base(
        endpoint, method, creds)
    {
    }

    protected override void AddAuth(IEnumerable<AuthenticationCredentialsProvider> creds)
    {
        var token = creds.Get(CredsNames.Token);
        
        this.AddHeader("Authorization", token.Value);
        this.AddHeader("Accept", "*/*");
    }
}