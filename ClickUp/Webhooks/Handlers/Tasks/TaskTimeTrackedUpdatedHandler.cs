using Apps.ClickUp.Models.Request.Team;
using Blackbird.Applications.Sdk.Common.Webhooks;

namespace Apps.ClickUp.Webhooks.Handlers.Tasks;

public class TaskTimeTrackedUpdatedHandler : BaseWebhookHandler
{
    protected override string EventType => "taskTimeTrackedUpdated";

    public TaskTimeTrackedUpdatedHandler([WebhookParameter] TeamRequest team) : base(team)
    {
    }
}