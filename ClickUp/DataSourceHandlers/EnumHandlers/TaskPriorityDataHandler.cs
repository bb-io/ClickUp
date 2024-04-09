using Blackbird.Applications.Sdk.Utils.Sdk.DataSourceHandlers;

namespace Apps.ClickUp.DataSourceHandlers.EnumHandlers;

public class TaskPriorityDataHandler : EnumDataHandler
{
    protected override Dictionary<string, string> EnumValues => new()
    {
        { "1", "Urgent" },
        { "2", "High" },
        { "3", "Normal" },
        { "4", "Low" },
    };
}