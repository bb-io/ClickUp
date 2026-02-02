using Apps.ClickUp.Models.Request.Team;
using Blackbird.Applications.Sdk.Common.Invocation;
using Blackbird.Applications.Sdk.Common.Webhooks;

namespace Apps.ClickUp.Webhooks.Handlers.Tasks;

public class TaskCommentPostedHandler : BaseWebhookHandler
{
    protected override string EventType => "taskCommentPosted";

    public TaskCommentPostedHandler(InvocationContext invocationContext, [WebhookParameter] WebhookScopeRequest team) : base(invocationContext,team)
    {
    }
}