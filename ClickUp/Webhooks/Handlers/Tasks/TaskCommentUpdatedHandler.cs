using Apps.ClickUp.Models.Request.Team;
using Blackbird.Applications.Sdk.Common.Webhooks;

namespace Apps.ClickUp.Webhooks.Handlers.Tasks;

public class TaskCommentUpdatedHandler : BaseWebhookHandler
{
    protected override string EventType => "taskCommentUpdated";

    public TaskCommentUpdatedHandler([WebhookParameter] TeamRequest team) : base(team)
    {
    }
}