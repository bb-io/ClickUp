using Apps.ClickUp.Models.Request.Task;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.ClickUp.DataSourceHandlers.Folder;

public class FolderTaskDataHandler : FolderDataHandler
{
    public FolderTaskDataHandler(InvocationContext invocationContext, [ActionParameter] TaskRequest request) :
        base(invocationContext, request.SpaceId)
    {
    }
}