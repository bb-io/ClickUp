using Apps.ClickUp.Models.Request.Team;
using Blackbird.Applications.Sdk.Common.Webhooks;

namespace Apps.ClickUp.Webhooks.Handlers.Folder;

public class FolderCreatedHandler : BaseWebhookHandler
{
    protected override string EventType => "folderCreated";

    public FolderCreatedHandler([WebhookParameter] TeamRequest team) : base(team)
    {
    }
}