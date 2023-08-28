using Blackbird.Applications.Sdk.Common.Webhooks;
using ClickUp.Models.Request.Team;

namespace ClickUp.Webhooks.Handlers.Space;

public class SpaceUpdatedHandler : BaseWebhookHandler
{
    protected override string EventType => "spaceUpdated";

    public SpaceUpdatedHandler([WebhookParameter] TeamRequest team) : base(team)
    {
    }
}