using Apps.ClickUp.Models.Request.Team;
using Blackbird.Applications.Sdk.Common.Webhooks;

namespace Apps.ClickUp.Webhooks.Handlers.Tasks;

public class TaskStatusUpdatedHandler : BaseWebhookHandler
{
    protected override string EventType => "taskStatusUpdated";

    public TaskStatusUpdatedHandler([WebhookParameter] TeamRequest team) : base(team)
    {
    }
}