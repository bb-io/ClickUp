using Apps.ClickUp.DataSourceHandlers;
using Apps.ClickUp.Webhooks.Handlers.Tasks.DataHandlers;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Dynamic;

namespace Apps.ClickUp.Webhooks.Handlers
{
    public class WebhookScopeRequest
    {
        [Display("Team")]
        [DataSource(typeof(TeamDataHandler))]
        public string TeamId { get; set; }

        [Display("Space ID")]
        [DataSource(typeof(SpaceWebhookDataHandler))]
        public string? SpaceId { get; set; }

        [Display("Folder ID")]
        [DataSource(typeof(FolderWebhookDataHandler))]
        public string? FolderId { get; set; }

        [Display("List ID")]
        [DataSource(typeof(ListWebhookDataHandler))]
        public string? ListId { get; set; }

        [Display("Task ID")]
        [DataSource(typeof(TaskWebhookDataHandler))]
        public string? TaskId { get; set; }
    }
}
