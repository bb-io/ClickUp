using ClickUp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickUp.Responses
{
    public class TeamResponse
    {
        [JsonProperty("teams")]
        public List<Team> Teams { get; set; }
    }
}
