using Blackbird.Applications.Sdk.Common;

namespace ClickUp.Models.Entities.Base;

public class ClickUpEntity
{
    public string Name { get; set; }

    [Display("Order index")] public double Orderindex { get; set; }

    public bool Archived { get; set; }

    [Display("Permission level")] public string PermissionLevel { get; set; }
}