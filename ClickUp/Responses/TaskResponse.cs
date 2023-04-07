using ClickUp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickUp.Responses
{
    public class TaskResponse
    {
        [JsonProperty("tasks")]
        public List<Models.Task> Tasks { get; set; }

        public TaskResponse() { Tasks = new List<Models.Task>(); }
    }
}
