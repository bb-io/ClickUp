using ClickUp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickUp.Responses
{
    public class ListResponse
    {
        [JsonProperty("lists")]
        public List<ListWithFolder> Lists { get; set; }

        public ListResponse() { Lists = new List<ListWithFolder>(); }
    }
}
