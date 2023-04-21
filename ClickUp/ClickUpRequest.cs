using Blackbird.Applications.Sdk.Common.Authentication;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickUp
{
    public class ClickUpRequest : RestRequest
    {
        public ClickUpRequest(string endpoint, Method method, IEnumerable<AuthenticationCredentialsProvider> authenticationCredentialsProviders) : base(endpoint, method)
        {
            var authenticationCredentialsProvider = authenticationCredentialsProviders.First(p => p.KeyName == "token");
            this.AddHeader("Authorization", authenticationCredentialsProvider.Value);
            this.AddHeader("accept", "*/*");
        }
    }
}
