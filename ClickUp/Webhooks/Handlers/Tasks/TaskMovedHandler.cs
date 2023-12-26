using Apps.ClickUp.Models.Request.Team;
using Blackbird.Applications.Sdk.Common.Webhooks;

namespace Apps.ClickUp.Webhooks.Handlers.Tasks;

public class TaskMovedHandler : BaseWebhookHandler
{
    protected override string EventType => "taskMoved";

    public TaskMovedHandler([WebhookParameter] TeamRequest team) : base(team)
    {
    }
}