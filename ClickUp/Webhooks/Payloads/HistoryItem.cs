using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickUp.Webhooks.Payloads
{
    public class HistoryItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("field")]
        public string Field { get; set; }

        [JsonProperty("parent_id")]
        public string ParentId { get; set; }

        //[JsonProperty("data")]
        //public Data Data { get; set; }

        //[JsonProperty("source")]
        //public object Source { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        //[JsonProperty("before")]
        //public Before Before { get; set; }

        //[JsonProperty("after")]
        //public After After { get; set; }
    }
}
