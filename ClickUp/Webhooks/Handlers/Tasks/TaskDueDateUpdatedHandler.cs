using Apps.ClickUp.Models.Request.Team;
using Blackbird.Applications.Sdk.Common.Webhooks;

namespace Apps.ClickUp.Webhooks.Handlers.Tasks;

public class TaskDueDateUpdatedHandler : BaseWebhookHandler
{
    protected override string EventType => "taskDueDateUpdated";

    public TaskDueDateUpdatedHandler([WebhookParameter] WebhookScopeRequest team) : base(team)
    {
    }
}