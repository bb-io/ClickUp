using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickUp.Webhooks.Payloads
{
    public class TaskPayload
    {
        [JsonProperty("event")]
        public string Event { get; set; }

        //[JsonProperty("history_items")]
        //public List<HistoryItem>? HistoryItems { get; set; }

        [JsonProperty("task_id")]
        public string TaskId { get; set; }

        [JsonProperty("webhook_id")]
        public string WebhookId { get; set; }
    }
}
