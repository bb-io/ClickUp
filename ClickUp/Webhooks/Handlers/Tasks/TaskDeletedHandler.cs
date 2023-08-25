using Blackbird.Applications.Sdk.Common.Webhooks;
using ClickUp.Models.Request.Team;

namespace ClickUp.Webhooks.Handlers.Tasks;

public class TaskDeletedHandler : BaseWebhookHandler
{
    protected override string EventType => "taskDeleted";

    public TaskDeletedHandler([WebhookParameter] TeamRequest team) : base(team)
    {
    }
}