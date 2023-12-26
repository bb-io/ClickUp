using Apps.ClickUp.Models.Request.Team;
using Blackbird.Applications.Sdk.Common.Webhooks;

namespace Apps.ClickUp.Webhooks.Handlers.Tasks;

public class TaskTimeEstimateUpdatedHandler : BaseWebhookHandler
{
    protected override string EventType => "taskTimeEstimateUpdated";

    public TaskTimeEstimateUpdatedHandler([WebhookParameter] TeamRequest team) : base(team)
    {
    }
}