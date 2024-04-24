using Blackbird.Applications.Sdk.Common.Dictionaries;

namespace Apps.ClickUp.DataSourceHandlers.Static;

public class TaskPriorityDataHandler : IStaticDataSourceHandler
{
    public Dictionary<string, string> GetData() => new()
    {
        { "1", "Urgent" },
        { "2", "High" },
        { "3", "Normal" },
        { "4", "Low" },
    };
}