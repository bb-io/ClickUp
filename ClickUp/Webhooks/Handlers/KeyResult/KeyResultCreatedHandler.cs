using Blackbird.Applications.Sdk.Common.Webhooks;
using ClickUp.Models.Request.Team;

namespace ClickUp.Webhooks.Handlers.KeyResult;

public class KeyResultCreatedHandler : BaseWebhookHandler
{
    protected override string EventType => "keyResultCreated";

    public KeyResultCreatedHandler([WebhookParameter] TeamRequest team) : base(team)
    {
    }
}