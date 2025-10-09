using Apps.ClickUp.Models.Request.CustomField;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.ClickUp.DataSourceHandlers.List;

public class ListCustomFieldDataHandler : ListDataHandler
{
    public ListCustomFieldDataHandler(InvocationContext invocationContext, [ActionParameter] CustomFieldRequest request)
        : base(invocationContext, request.FolderId)
    {
    }
}