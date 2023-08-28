using Blackbird.Applications.Sdk.Common.Webhooks;
using ClickUp.Models.Request.Team;

namespace ClickUp.Webhooks.Handlers.Folder;

public class FolderUpdatedHandler : BaseWebhookHandler
{
    protected override string EventType => "folderUpdated";

    public FolderUpdatedHandler([WebhookParameter] TeamRequest team) : base(team)
    {
    }
}