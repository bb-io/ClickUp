using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Authentication;
using RestSharp;

namespace ClickUp
{
    [ActionList]
    public class Actions
    {
        [Action("Get all teams", Description = "Get all teams for this user connection")]
        public void GetTeams(AuthenticationCredentialsProvider authenticationCredentialsProvider)
        {
            var client = new ClickUpClient();
            var request = new ClickUpRequest("/team", Method.Get, authenticationCredentialsProvider.Value);
            var response = client.Get(request);

        }
    }
}