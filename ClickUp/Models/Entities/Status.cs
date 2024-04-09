using Blackbird.Applications.Sdk.Common;

namespace Apps.ClickUp.Models.Entities;

public class StatusModel
{
    [Display("Status ID")]
    public string Id { get; set; }

    public string Status { get; set; }

    public string Type { get; set; }

    [Display("Order index")]
    public double Orderindex { get; set; }

    public string Color { get; set; }
}