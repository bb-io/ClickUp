using Apps.ClickUp.Models.Request.Team;
using Blackbird.Applications.Sdk.Common.Webhooks;

namespace Apps.ClickUp.Webhooks.Handlers.Tasks;

public class TaskCreatedHandler : BaseWebhookHandler
{
    protected override string EventType => "taskCreated";

    public TaskCreatedHandler([WebhookParameter] TeamRequest team) : base(team)
    {
    }
}