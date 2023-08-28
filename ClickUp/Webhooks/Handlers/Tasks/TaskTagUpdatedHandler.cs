using Blackbird.Applications.Sdk.Common.Webhooks;
using ClickUp.Models.Request.Team;

namespace ClickUp.Webhooks.Handlers.Tasks;

public class TaskTagUpdatedHandler : BaseWebhookHandler
{
    protected override string EventType => "taskTagUpdated";

    public TaskTagUpdatedHandler([WebhookParameter] TeamRequest team) : base(team)
    {
    }
}