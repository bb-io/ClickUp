using Blackbird.Applications.Sdk.Common;

namespace ClickUp.Models.Request.List;

public class ListRequest
{
    [Display("List ID")]
    public string ListId { get; set; }
}