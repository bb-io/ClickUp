using Apps.ClickUp.Models.Request.Team;
using Blackbird.Applications.Sdk.Common.Webhooks;

namespace Apps.ClickUp.Webhooks.Handlers.List;

public class ListDeletedHandler : BaseWebhookHandler
{
    protected override string EventType => "listDeleted";

    public ListDeletedHandler([WebhookParameter] TeamRequest team) : base(team)
    {
    }
}