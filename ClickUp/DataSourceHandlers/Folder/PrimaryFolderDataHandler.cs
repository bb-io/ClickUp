using Apps.ClickUp.Models.Request.Folder;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.ClickUp.DataSourceHandlers.Folder;

public class PrimaryFolderDataHandler : FolderDataHandler
{
    public PrimaryFolderDataHandler(InvocationContext invocationContext, [ActionParameter] FolderRequest request) :
        base(invocationContext, request.SpaceId)
    {
    }
}