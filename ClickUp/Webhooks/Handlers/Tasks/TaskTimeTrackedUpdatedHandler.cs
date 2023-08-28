using Blackbird.Applications.Sdk.Common.Webhooks;
using ClickUp.Models.Request.Team;

namespace ClickUp.Webhooks.Handlers.Tasks;

public class TaskTimeTrackedUpdatedHandler : BaseWebhookHandler
{
    protected override string EventType => "taskTimeTrackedUpdated";

    public TaskTimeTrackedUpdatedHandler([WebhookParameter] TeamRequest team) : base(team)
    {
    }
}