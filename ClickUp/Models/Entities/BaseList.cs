using Blackbird.Applications.Sdk.Common;
using ClickUp.Models.Entities.Base;

namespace ClickUp.Models.Entities;

public class BaseList : ClickUpEntity
{
    [Display("List ID")] public string Id { get; set; }

    [Display("Task count")] public int TaskCount { get; set; }

    public List<StatusModel> Statuses { get; set; }
}