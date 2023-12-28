using Apps.ClickUp.Models.Request.Team;
using Blackbird.Applications.Sdk.Common.Webhooks;

namespace Apps.ClickUp.Webhooks.Handlers.Tasks;

public class TaskPriorityUpdatedHandler : BaseWebhookHandler
{
    protected override string EventType => "taskPriorityUpdated";

    public TaskPriorityUpdatedHandler([WebhookParameter] TeamRequest team) : base(team)
    {
    }
}