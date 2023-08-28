using Blackbird.Applications.Sdk.Common.Webhooks;
using ClickUp.Models.Request.Team;

namespace ClickUp.Webhooks.Handlers.List;

public class ListDeletedHandler : BaseWebhookHandler
{
    protected override string EventType => "listDeleted";

    public ListDeletedHandler([WebhookParameter] TeamRequest team) : base(team)
    {
    }
}