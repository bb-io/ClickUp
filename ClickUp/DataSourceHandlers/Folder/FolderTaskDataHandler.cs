using Apps.ClickUp.Constants;
using Apps.ClickUp.Models.Request.Task;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;
using Blackbird.Applications.Sdk.Utils.Extensions.Sdk;

namespace Apps.ClickUp.DataSourceHandlers.Folder;

public class FolderTaskDataHandler : FolderDataHandler
{
    public FolderTaskDataHandler(InvocationContext invocationContext) :
        base(invocationContext)
    {
    }
}