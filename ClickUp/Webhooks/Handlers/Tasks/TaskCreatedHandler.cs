using Blackbird.Applications.Sdk.Common.Webhooks;
using ClickUp.Models.Request.Team;

namespace ClickUp.Webhooks.Handlers.Tasks;

public class TaskCreatedHandler : BaseWebhookHandler
{
    protected override string EventType => "taskCreated";

    public TaskCreatedHandler([WebhookParameter] TeamRequest team) : base(team)
    {
    }
}