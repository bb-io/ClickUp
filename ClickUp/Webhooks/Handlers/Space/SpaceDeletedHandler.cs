using Apps.ClickUp.Models.Request.Team;
using Blackbird.Applications.Sdk.Common.Webhooks;

namespace Apps.ClickUp.Webhooks.Handlers.Space;

public class SpaceDeletedHandler : BaseWebhookHandler
{
    protected override string EventType => "spaceDeleted";

    public SpaceDeletedHandler([WebhookParameter] TeamRequest team) : base(team)
    {
    }
}