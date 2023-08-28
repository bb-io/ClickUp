using Blackbird.Applications.Sdk.Common.Webhooks;
using ClickUp.Models.Request.Team;

namespace ClickUp.Webhooks.Handlers.Space;

public class SpaceDeletedHandler : BaseWebhookHandler
{
    protected override string EventType => "spaceDeleted";

    public SpaceDeletedHandler([WebhookParameter] TeamRequest team) : base(team)
    {
    }
}