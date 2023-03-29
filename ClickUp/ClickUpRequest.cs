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
        public ClickUpRequest(string endpoint, Method method, string token) : base(endpoint, method)
        {
            this.AddHeader("Authorization", token);
            this.AddHeader("accept", "*/*");
        }
    }
}
