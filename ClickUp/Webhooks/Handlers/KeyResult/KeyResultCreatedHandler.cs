using Apps.ClickUp.Models.Request.Team;
using Blackbird.Applications.Sdk.Common.Webhooks;

namespace Apps.ClickUp.Webhooks.Handlers.KeyResult;

public class KeyResultCreatedHandler : BaseWebhookHandler
{
    protected override string EventType => "keyResultCreated";

    public KeyResultCreatedHandler([WebhookParameter] TeamRequest team) : base(team)
    {
    }
}