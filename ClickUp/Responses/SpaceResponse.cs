using ClickUp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickUp.Responses
{
    public class SpaceResponse
    {
        [JsonProperty("spaces")]
        public List<Space> Spaces { get; set; }

        public SpaceResponse() { Spaces = new List<Space>(); }
    }
}
