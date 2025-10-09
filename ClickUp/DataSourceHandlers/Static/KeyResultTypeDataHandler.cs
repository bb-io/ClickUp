using Blackbird.Applications.Sdk.Common.Dictionaries;

namespace Apps.ClickUp.DataSourceHandlers.Static;

public class KeyResultTypeDataHandler : IStaticDataSourceHandler
{
    public Dictionary<string, string> GetData() => new()
    {
        { "number", "Number" },
        { "currency", "Currency" },
        { "boolean", "Boolean" },
        { "percentage", "Percentage" },
        { "automatic", "Automatic" },
    };
}