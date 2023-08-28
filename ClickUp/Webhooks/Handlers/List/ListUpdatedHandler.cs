using Blackbird.Applications.Sdk.Common.Webhooks;
using ClickUp.Models.Request.Team;

namespace ClickUp.Webhooks.Handlers.List;

public class ListUpdatedHandler : BaseWebhookHandler
{
    protected override string EventType => "listUpdated";

    public ListUpdatedHandler([WebhookParameter] TeamRequest team) : base(team)
    {
    }
}