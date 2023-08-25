using Blackbird.Applications.Sdk.Common.Webhooks;
using ClickUp.Models.Request.Team;

namespace ClickUp.Webhooks.Handlers.Tasks;

public class TaskPriorityUpdatedHandler : BaseWebhookHandler
{
    protected override string EventType => "taskPriorityUpdated";

    public TaskPriorityUpdatedHandler([WebhookParameter] TeamRequest team) : base(team)
    {
    }
}