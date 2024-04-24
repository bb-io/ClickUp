using Apps.ClickUp.Models.Request.Task;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.ClickUp.DataSourceHandlers.List;

public class ListTaskDataHandler : ListDataHandler
{
    public ListTaskDataHandler(InvocationContext invocationContext, [ActionParameter] TaskRequest request) :
        base(invocationContext, request.FolderId)
    {
    }
}