using Blackbird.Applications.Sdk.Common;

namespace ClickUp.Webhooks.Models.Payloads;

public class HistoryItem
{
    [Display("ID")]
    public string Id { get; set; }

    public int Type { get; set; }

    public string Date { get; set; }

    public string Field { get; set; }

    [Display("Parent ID")]
    public string ParentId { get; set; }

    public User User { get; set; }

}