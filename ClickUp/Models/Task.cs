using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickUp.Models
{
    public class Task
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        //[JsonProperty("custom_id")]
        //public object CustomId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("text_content")]
        public string TextContent { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("status")]
        public StatusModel Status { get; set; }

        [JsonProperty("orderindex")]
        public string Orderindex { get; set; }

        [JsonProperty("date_created")]
        public string DateCreated { get; set; }

        [JsonProperty("date_updated")]
        public string DateUpdated { get; set; }

        [JsonProperty("date_closed")]
        public string DateClosed { get; set; }

        [JsonProperty("date_done")]
        public string DateDone { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        //[JsonProperty("creator")]
        //public Creator Creator { get; set; }

        //[JsonProperty("assignees")]
        //public List<object> Assignees { get; set; }

        //[JsonProperty("watchers")]
        //public List<object> Watchers { get; set; }

        //[JsonProperty("checklists")]
        //public List<object> Checklists { get; set; }

        //[JsonProperty("tags")]
        //public List<object> Tags { get; set; }

        //[JsonProperty("parent")]
        //public object Parent { get; set; }

        //[JsonProperty("priority")]
        //public object Priority { get; set; }

        //[JsonProperty("due_date")]
        //public object DueDate { get; set; }

        //[JsonProperty("start_date")]
        //public object StartDate { get; set; }

        //[JsonProperty("points")]
        //public object Points { get; set; }

        //[JsonProperty("time_estimate")]
        //public object TimeEstimate { get; set; }

        [JsonProperty("custom_fields")]
        public List<CustomField> CustomFields { get; set; }

        //[JsonProperty("dependencies")]
        //public List<object> Dependencies { get; set; }

        //[JsonProperty("linked_tasks")]
        //public List<object> LinkedTasks { get; set; }

        [JsonProperty("team_id")]
        public string TeamId { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        //[JsonProperty("sharing")]
        //public Sharing Sharing { get; set; }

        [JsonProperty("permission_level")]
        public string PermissionLevel { get; set; }

        //[JsonProperty("list")]
        //public List List { get; set; }

        //[JsonProperty("project")]
        //public Project Project { get; set; }

        //[JsonProperty("folder")]
        //public Folder Folder { get; set; }

        //[JsonProperty("space")]
        //public Space Space { get; set; }

        [JsonProperty("time_spent")]
        public int? TimeSpent { get; set; }
    }
}
