using Blackbird.Applications.Sdk.Common.Webhooks;
using ClickUp.Models.Request.Team;

namespace ClickUp.Webhooks.Handlers.KeyResult;

public class KeyResultDeletedHandler : BaseWebhookHandler
{
    protected override string EventType => "keyResultDeleted";

    public KeyResultDeletedHandler([WebhookParameter] TeamRequest team) : base(team)
    {
    }
}