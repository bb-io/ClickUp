using Apps.ClickUp.Extensions;
using Apps.ClickUp.Models.Entities.CustomFields.Dropdown;
using Apps.ClickUp.Models.Request.CustomField;
using Apps.ClickUp.Models.Request.Task;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Dynamic;
using Blackbird.Applications.Sdk.Common.Exceptions;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.ClickUp.DataSourceHandlers.CustomField.Value;

public class DropdownValueCustomFieldDataHandler : BaseValueCustomFieldDataHandler<DropdownCustomFieldEntity>, IAsyncDataSourceItemHandler
{
    protected override string FieldType => "drop_down";
    
    public DropdownValueCustomFieldDataHandler(
        InvocationContext invocationContext, 
        [ActionParameter] TaskRequest taskRequest,
        [ActionParameter] CustomDropdownFieldRequest fieldRequest) : base(invocationContext, taskRequest, fieldRequest.FieldId)
    {
        if (string.IsNullOrWhiteSpace(fieldRequest.FieldId))
            throw new PluginMisconfigurationException("Please specify a dropdown ID first");
    }
    
    public async Task<IEnumerable<DataSourceItem>> GetDataAsync(DataSourceContext context, CancellationToken cancellationToken)
    {
        var customFields = await GetCustomFields();
        var options = customFields.SelectMany(f => f.TypeConfig.Options);

        return options
            .Where(x => x.Name.ContainsIgnoreCase(context.SearchString))
            .Select(x => new DataSourceItem(x.Id, $"{x.OrderIndex}. {x.Name}"))
            .ToList();
    }
}