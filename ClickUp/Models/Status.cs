using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickUp.Models
{
    public class StatusModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("orderindex")]
        public int Orderindex { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }
    }
}
