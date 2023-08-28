using Blackbird.Applications.Sdk.Common.Webhooks;
using ClickUp.Models.Request.Team;

namespace ClickUp.Webhooks.Handlers.Tasks;

public class TaskCommentUpdatedHandler : BaseWebhookHandler
{
    protected override string EventType => "taskCommentUpdated";

    public TaskCommentUpdatedHandler([WebhookParameter] TeamRequest team) : base(team)
    {
    }
}