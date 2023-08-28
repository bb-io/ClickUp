using Blackbird.Applications.Sdk.Common.Webhooks;
using ClickUp.Models.Request.Team;

namespace ClickUp.Webhooks.Handlers.List;

public class ListCreatedHandler : BaseWebhookHandler
{
    protected override string EventType => "listCreated";

    public ListCreatedHandler([WebhookParameter] TeamRequest team) : base(team)
    {
    }
}