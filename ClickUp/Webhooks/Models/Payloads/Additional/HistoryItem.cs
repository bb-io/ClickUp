using Apps.ClickUp.Utils.Converters;
using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.ClickUp.Webhooks.Models.Payloads.Additional;

public class HistoryItem
{
    [Display("ID")]
    public string Id { get; set; }

    public int Type { get; set; }

    [JsonConverter(typeof(UnixTimestampConverter))]
    public DateTime Date { get; set; }

    public string Field { get; set; }

    [Display("Parent ID")]
    public string ParentId { get; set; }

    public User User { get; set; }

}