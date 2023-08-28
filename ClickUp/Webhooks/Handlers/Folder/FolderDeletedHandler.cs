using Blackbird.Applications.Sdk.Common.Webhooks;
using ClickUp.Models.Request.Team;

namespace ClickUp.Webhooks.Handlers.Folder;

public class FolderDeletedHandler : BaseWebhookHandler
{
    protected override string EventType => "folderDeleted";

    public FolderDeletedHandler([WebhookParameter] TeamRequest team) : base(team)
    {
    }
}