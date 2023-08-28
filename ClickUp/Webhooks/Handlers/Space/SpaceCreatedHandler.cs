using Blackbird.Applications.Sdk.Common.Webhooks;
using ClickUp.Models.Request.Team;

namespace ClickUp.Webhooks.Handlers.Space;

public class SpaceCreatedHandler : BaseWebhookHandler
{
    protected override string EventType => "spaceCreated";

    public SpaceCreatedHandler([WebhookParameter] TeamRequest team) : base(team)
    {
    }
}