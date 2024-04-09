using Apps.ClickUp.Models.Request.Team;
using Blackbird.Applications.Sdk.Common.Webhooks;

namespace Apps.ClickUp.Webhooks.Handlers.Tasks;

public class TaskTagUpdatedHandler : BaseWebhookHandler
{
    protected override string EventType => "taskTagUpdated";

    public TaskTagUpdatedHandler([WebhookParameter] TeamRequest team) : base(team)
    {
    }
}