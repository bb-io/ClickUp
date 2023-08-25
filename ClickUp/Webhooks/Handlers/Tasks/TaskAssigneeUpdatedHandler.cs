using Blackbird.Applications.Sdk.Common.Webhooks;
using ClickUp.Models.Request.Team;

namespace ClickUp.Webhooks.Handlers.Tasks;

public class TaskAssigneeUpdatedHandler : BaseWebhookHandler
{
    protected override string EventType => "taskAssigneeUpdated";

    public TaskAssigneeUpdatedHandler([WebhookParameter] TeamRequest team) : base(team)
    {
    }
}