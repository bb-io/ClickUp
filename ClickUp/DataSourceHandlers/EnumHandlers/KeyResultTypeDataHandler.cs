using Blackbird.Applications.Sdk.Utils.Sdk.DataSourceHandlers;

namespace Apps.ClickUp.DataSourceHandlers.EnumHandlers;

public class KeyResultTypeDataHandler : EnumDataHandler
{
    protected override Dictionary<string, string> EnumValues => new()
    {
        { "number", "Number" },
        { "currency", "Currency" },
        { "boolean", "Boolean" },
        { "percentage", "Percentage" },
        { "automatic", "Automatic" },
    };
}