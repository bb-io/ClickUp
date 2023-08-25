using Blackbird.Applications.Sdk.Common.Webhooks;
using ClickUp.Models.Request.Team;

namespace ClickUp.Webhooks.Handlers.Tasks;

public class TaskDueDateUpdatedHandler : BaseWebhookHandler
{
    protected override string EventType => "taskDueDateUpdated";

    public TaskDueDateUpdatedHandler([WebhookParameter] TeamRequest team) : base(team)
    {
    }
}