using Apps.ClickUp.Models.Request.Team;
using Blackbird.Applications.Sdk.Common.Webhooks;

namespace Apps.ClickUp.Webhooks.Handlers.KeyResult;

public class KeyResultDeletedHandler : BaseWebhookHandler
{
    protected override string EventType => "keyResultDeleted";

    public KeyResultDeletedHandler([WebhookParameter] TeamRequest team) : base(team)
    {
    }
}