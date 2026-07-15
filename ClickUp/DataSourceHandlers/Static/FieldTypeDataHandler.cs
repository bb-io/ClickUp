using Blackbird.Applications.Sdk.Common.Dictionaries;
using Blackbird.Applications.Sdk.Common.Dynamic;

namespace Apps.ClickUp.DataSourceHandlers.Static;

public class FieldTypeDataHandler : IStaticDataSourceItemHandler
{
    public IEnumerable<DataSourceItem> GetData()
    {
        return
        [
            new("url", "Website URL"),
            new("drop_down", "Dropdown"),
            new("labels", "Labels"),
            new("email", "Email"),
            new("phone", "Phone"),
            new("date", "Date"),
            new("short_text", "Short Text"),
            new("text", "Text"),
            new("checkbox", "Checkbox"),
            new("number", "Number"),
            new("currency", "Currency"),
            new("tasks", "Tasks"),
            new("users", "Users"),
            new("emoji", "Rating"),
            new("automatic_progress", "Auto Progress"),
            new("manual_progress", "Manual Progress"),
            new("location", "Location")
        ];
    }
}