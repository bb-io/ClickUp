using Apps.ClickUp.Models.Request.Team;
using Blackbird.Applications.Sdk.Common.Webhooks;

namespace Apps.ClickUp.Webhooks.Handlers.List;

public class ListUpdatedHandler : BaseWebhookHandler
{
    protected override string EventType => "listUpdated";

    public ListUpdatedHandler([WebhookParameter] TeamRequest team) : base(team)
    {
    }
}