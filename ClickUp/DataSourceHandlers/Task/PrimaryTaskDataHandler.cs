using Apps.ClickUp.Models.Request.Task;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.ClickUp.DataSourceHandlers.Task;

public class PrimaryTaskDataHandler : TaskDataHandler
{
    public PrimaryTaskDataHandler(InvocationContext invocationContext, [ActionParameter] TaskRequest request)
        : base(invocationContext, request.ListId)
    {
    }
}