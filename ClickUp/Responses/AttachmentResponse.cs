using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickUp.Responses
{
    public class AttachmentResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("date")]
        public long Date { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("thumbnail_small")]
        public string ThumbnailSmall { get; set; }

        [JsonProperty("thumbnail_large")]
        public string ThumbnailLarge { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
