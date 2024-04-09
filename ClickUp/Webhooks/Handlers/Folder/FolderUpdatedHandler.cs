using Apps.ClickUp.Models.Request.Team;
using Blackbird.Applications.Sdk.Common.Webhooks;

namespace Apps.ClickUp.Webhooks.Handlers.Folder;

public class FolderUpdatedHandler : BaseWebhookHandler
{
    protected override string EventType => "folderUpdated";

    public FolderUpdatedHandler([WebhookParameter] TeamRequest team) : base(team)
    {
    }
}