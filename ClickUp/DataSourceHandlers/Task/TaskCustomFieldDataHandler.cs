using Apps.ClickUp.Models.Request.CustomField;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.ClickUp.DataSourceHandlers.Task;

public class TaskCustomFieldDataHandler : TaskDataHandler
{
    public TaskCustomFieldDataHandler(InvocationContext invocationContext, [ActionParameter] CustomFieldRequest request)
        : base(invocationContext, request.ListId)
    {
    }
}