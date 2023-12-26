using Apps.ClickUp.Models.Request.Team;
using Blackbird.Applications.Sdk.Common.Webhooks;

namespace Apps.ClickUp.Webhooks.Handlers.Tasks;

public class TaskCommentPostedHandler : BaseWebhookHandler
{
    protected override string EventType => "taskCommentPosted";

    public TaskCommentPostedHandler([WebhookParameter] TeamRequest team) : base(team)
    {
    }
}