using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickUp.Webhooks.Handlers
{
    public class TaskCreatedHandler : BaseWebhookHandler
    {
        public TaskCreatedHandler() : base("taskCreated") { }
    }

    public class TaskUpdatedHandler : BaseWebhookHandler
    {
        public TaskUpdatedHandler() : base("taskUpdated") { }
    }

    public class TaskDeletedHandler : BaseWebhookHandler
    {
        public TaskDeletedHandler() : base("taskDeleted") { }
    }

    public class TaskPriorityUpdatedHandler : BaseWebhookHandler
    {
        public TaskPriorityUpdatedHandler() : base("taskPriorityUpdated") { }
    }

    public class TaskStatusUpdatedHandler : BaseWebhookHandler
    {
        public TaskStatusUpdatedHandler() : base("taskStatusUpdated") { }
    }

    public class TaskAssigneeUpdatedHandler : BaseWebhookHandler
    {
        public TaskAssigneeUpdatedHandler() : base("taskAssigneeUpdated") { }
    }

    public class TaskDueDateUpdatedHandler : BaseWebhookHandler
    {
        public TaskDueDateUpdatedHandler() : base("taskDueDateUpdated") { }
    }
}
