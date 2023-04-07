using ClickUp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickUp.Requests
{
    public class CreateTask
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("assignees")]
        public List<int> Assignees { get; set; }

        [JsonProperty("tags")]
        public List<string> Tags { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("due_date")]
        public long DueDate { get; set; }

        [JsonProperty("due_date_time")]
        public bool DueDateTime { get; set; }

        [JsonProperty("time_estimate")]
        public int TimeEstimate { get; set; }

        [JsonProperty("start_date")]
        public long StartDate { get; set; }

        [JsonProperty("start_date_time")]
        public bool StartDateTime { get; set; }

        [JsonProperty("notify_all")]
        public bool NotifyAll { get; set; }

        [JsonProperty("parent")]
        public string Parent { get; set; }

        [JsonProperty("links_to")]
        public string LinksTo { get; set; }

        [JsonProperty("check_required_custom_fields")]
        public bool CheckRequiredCustomFields { get; set; }

        [JsonProperty("custom_fields")]
        public List<SimpleCustomField> CustomFields { get; set; }
    }
}
