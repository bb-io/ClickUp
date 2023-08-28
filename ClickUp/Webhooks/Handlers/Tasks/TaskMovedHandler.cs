using Blackbird.Applications.Sdk.Common.Webhooks;
using ClickUp.Models.Request.Team;

namespace ClickUp.Webhooks.Handlers.Tasks;

public class TaskMovedHandler : BaseWebhookHandler
{
    protected override string EventType => "taskMoved";

    public TaskMovedHandler([WebhookParameter] TeamRequest team) : base(team)
    {
    }
}