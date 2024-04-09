using Apps.ClickUp.Models.Request.Team;
using Blackbird.Applications.Sdk.Common.Webhooks;

namespace Apps.ClickUp.Webhooks.Handlers.KeyResult;

public class KeyResultUpdatedHandler : BaseWebhookHandler
{
    protected override string EventType => "keyResultUpdated";

    public KeyResultUpdatedHandler([WebhookParameter] TeamRequest team) : base(team)
    {
    }
}