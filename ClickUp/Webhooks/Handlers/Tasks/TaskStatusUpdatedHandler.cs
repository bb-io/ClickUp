using Blackbird.Applications.Sdk.Common.Webhooks;
using ClickUp.Models.Request.Team;

namespace ClickUp.Webhooks.Handlers.Tasks;

public class TaskStatusUpdatedHandler : BaseWebhookHandler
{
    protected override string EventType => "taskStatusUpdated";

    public TaskStatusUpdatedHandler([WebhookParameter] TeamRequest team) : base(team)
    {
    }
}