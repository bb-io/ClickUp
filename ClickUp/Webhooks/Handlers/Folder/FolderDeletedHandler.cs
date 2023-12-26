using Apps.ClickUp.Models.Request.Team;
using Blackbird.Applications.Sdk.Common.Webhooks;

namespace Apps.ClickUp.Webhooks.Handlers.Folder;

public class FolderDeletedHandler : BaseWebhookHandler
{
    protected override string EventType => "folderDeleted";

    public FolderDeletedHandler([WebhookParameter] TeamRequest team) : base(team)
    {
    }
}