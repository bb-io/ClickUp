using Apps.ClickUp.Models.Request.Team;
using Blackbird.Applications.Sdk.Common.Webhooks;

namespace Apps.ClickUp.Webhooks.Handlers.Space;

public class SpaceCreatedHandler : BaseWebhookHandler
{
    protected override string EventType => "spaceCreated";

    public SpaceCreatedHandler([WebhookParameter] WebhookScopeRequest team) : base(team)
    {
    }
}