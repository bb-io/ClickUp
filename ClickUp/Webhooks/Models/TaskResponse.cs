using ClickUp.Webhooks.Payloads;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickUp.Webhooks.Models
{
    public class TaskResponse
    {
        public string TaskId { get; set; }

        public static TaskResponse FromTaskPayload(TaskPayload payload)
        {
            return new TaskResponse
            {
                TaskId = payload.TaskId
            };
        }
    }
}
