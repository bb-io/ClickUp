using Apps.ClickUp.Models.Request.Folder;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.ClickUp.DataSourceHandlers.Space;

public class SpaceFolderDataHandler : SpaceDataHandler
{
    public SpaceFolderDataHandler(InvocationContext invocationContext, [ActionParameter] FolderRequest request) :
        base(invocationContext, request.TeamId)
    {
    }
}