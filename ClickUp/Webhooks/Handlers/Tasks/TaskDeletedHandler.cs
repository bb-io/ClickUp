using Apps.ClickUp.Models.Request.Team;
using Blackbird.Applications.Sdk.Common.Webhooks;

namespace Apps.ClickUp.Webhooks.Handlers.Tasks;

public class TaskDeletedHandler : BaseWebhookHandler
{
    protected override string EventType => "taskDeleted";

    public TaskDeletedHandler([WebhookParameter] TeamRequest team) : base(team)
    {
    }
}