using Blackbird.Applications.Sdk.Common.Webhooks;
using ClickUp.Models.Request.Team;

namespace ClickUp.Webhooks.Handlers.Tasks;

public class TaskUpdatedHandler : BaseWebhookHandler
{
    protected override string EventType => "taskUpdated";

    public TaskUpdatedHandler([WebhookParameter] TeamRequest team) : base(team)
    {
    }
}