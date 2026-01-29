using Apps.ClickUp.Models.Request.Team;
using Blackbird.Applications.Sdk.Common.Webhooks;

namespace Apps.ClickUp.Webhooks.Handlers.Tasks;

public class TaskAssigneeUpdatedHandler : BaseWebhookHandler
{
    protected override string EventType => "taskAssigneeUpdated";

    public TaskAssigneeUpdatedHandler([WebhookParameter] WebhookScopeRequest team) : base(team)
    {
    }
}