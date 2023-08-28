using Blackbird.Applications.Sdk.Common.Webhooks;
using ClickUp.Models.Request.Team;

namespace ClickUp.Webhooks.Handlers.KeyResult;

public class KeyResultUpdatedHandler : BaseWebhookHandler
{
    protected override string EventType => "keyResultUpdated";

    public KeyResultUpdatedHandler([WebhookParameter] TeamRequest team) : base(team)
    {
    }
}