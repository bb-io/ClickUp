using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickUp.Webhooks.Responses
{
    public class Webhook
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("userid")]
        public int Userid { get; set; }

        [JsonProperty("team_id")]
        public int TeamId { get; set; }

        [JsonProperty("endpoint")]
        public string Endpoint { get; set; }

        [JsonProperty("client_id")]
        public string ClientId { get; set; }

        [JsonProperty("events")]
        public List<string> Events { get; set; }

        //[JsonProperty("task_id")]
        //public object TaskId { get; set; }

        //[JsonProperty("list_id")]
        //public object ListId { get; set; }

        //[JsonProperty("folder_id")]
        //public object FolderId { get; set; }

        //[JsonProperty("space_id")]
        //public object SpaceId { get; set; }

        //[JsonProperty("health")]
        //public Health Health { get; set; }

        [JsonProperty("secret")]
        public string Secret { get; set; }
    }
}
