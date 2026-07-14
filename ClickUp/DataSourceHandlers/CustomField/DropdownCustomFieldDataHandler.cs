using Apps.ClickUp.Models.Request.Task;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Dynamic;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.ClickUp.DataSourceHandlers.CustomField;

public class DropdownCustomFieldDataHandler(InvocationContext invocationContext, [ActionParameter] TaskRequest task)
    : BaseCustomFieldDataHandler(invocationContext, task), IAsyncDataSourceItemHandler
{
    protected override string[] Types => ["drop_down"];

    public Task<IEnumerable<DataSourceItem>> GetDataAsync(DataSourceContext context, CancellationToken ct)
    {
        return base.GetDataAsync(context);
    }
}