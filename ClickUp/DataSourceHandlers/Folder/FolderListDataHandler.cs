using Apps.ClickUp.Models.Request.List;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.ClickUp.DataSourceHandlers.Folder;

public class FolderListDataHandler : FolderDataHandler
{
    public FolderListDataHandler(InvocationContext invocationContext, [ActionParameter] ListRequest request) :
        base(invocationContext, request.SpaceId)
    {
    }
}