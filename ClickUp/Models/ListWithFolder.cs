﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickUp.Models
{
    public class ListWithFolder
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("orderindex")]
        public int Orderindex { get; set; }

        //[JsonProperty("status")]
        //public object Status { get; set; }

        //[JsonProperty("priority")]
        //public object Priority { get; set; }

        //[JsonProperty("assignee")]
        //public object Assignee { get; set; }

        [JsonProperty("task_count")]
        public int TaskCount { get; set; }

        //[JsonProperty("due_date")]
        //public object DueDate { get; set; }

        //[JsonProperty("start_date")]
        //public object StartDate { get; set; }

        //[JsonProperty("folder")]
        //public SimpleFolder Folder { get; set; }

        //[JsonProperty("space")]
        //public SimpleSpace Space { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("override_statuses")]
        public bool OverrideStatuses { get; set; }

        [JsonProperty("permission_level")]
        public string PermissionLevel { get; set; }
    }
}
