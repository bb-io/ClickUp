using Blackbird.Applications.Sdk.Common.Webhooks;
using ClickUp.Models.Request.Team;

namespace ClickUp.Webhooks.Handlers.Tasks;

public class TaskTimeEstimateUpdatedHandler : BaseWebhookHandler
{
    protected override string EventType => "taskTimeEstimateUpdated";

    public TaskTimeEstimateUpdatedHandler([WebhookParameter] TeamRequest team) : base(team)
    {
    }
}