using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickUp.Webhooks.Responses
{
    public class WebhooksResponse
    {
        [JsonProperty("webhooks")]
        public List<Webhook> Webhooks { get; set; }
    }
}
