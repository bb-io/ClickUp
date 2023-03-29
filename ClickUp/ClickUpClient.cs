using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickUp
{
    public class ClickUpClient : RestClient
    {
        public ClickUpClient() : base(new RestClientOptions() { ThrowOnAnyError = true, BaseUrl = new Uri("https://api.clickup.com/api/v2") }) { }
    }
}
