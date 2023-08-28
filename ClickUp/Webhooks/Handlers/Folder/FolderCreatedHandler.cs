using Blackbird.Applications.Sdk.Common.Webhooks;
using ClickUp.Models.Request.Team;

namespace ClickUp.Webhooks.Handlers.Folder;

public class FolderCreatedHandler : BaseWebhookHandler
{
    protected override string EventType => "folderCreated";

    public FolderCreatedHandler([WebhookParameter] TeamRequest team) : base(team)
    {
    }
}