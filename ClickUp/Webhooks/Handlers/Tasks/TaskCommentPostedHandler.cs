using Blackbird.Applications.Sdk.Common.Webhooks;
using ClickUp.Models.Request.Team;

namespace ClickUp.Webhooks.Handlers.Tasks;

public class TaskCommentPostedHandler : BaseWebhookHandler
{
    protected override string EventType => "taskCommentPosted";

    public TaskCommentPostedHandler([WebhookParameter] TeamRequest team) : base(team)
    {
    }
}