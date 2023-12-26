using Apps.ClickUp.Models.Request.Team;
using Blackbird.Applications.Sdk.Common.Webhooks;

namespace Apps.ClickUp.Webhooks.Handlers.List;

public class ListCreatedHandler : BaseWebhookHandler
{
    protected override string EventType => "listCreated";

    public ListCreatedHandler([WebhookParameter] TeamRequest team) : base(team)
    {
    }
}