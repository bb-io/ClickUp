using Apps.ClickUp.Models.Request.Team;
using Blackbird.Applications.Sdk.Common.Webhooks;

namespace Apps.ClickUp.Webhooks.Handlers.Tasks;

public class TaskUpdatedHandler : BaseWebhookHandler
{
    protected override string EventType => "taskUpdated";

    public TaskUpdatedHandler([WebhookParameter] TeamRequest team) : base(team)
    {
    }
}