using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickUp.Models
{
    public class TaskWithStatus
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Content { get; set; }

        public string Description { get; set; }
        public string Url { get; set; }
        public string Status { get; set; }
        public string StatusId { get; set; }

        public static TaskWithStatus FromTask(Models.Task task)
        {
            return new TaskWithStatus
            {
                Id = task.Id,
                Name = task.Name,
                Content = task.TextContent,
                Description = task.Description,
                Url = task.Url,
                StatusId = task.Status.Id,
                Status = task.Status.Status
            };
        }
    }
}
