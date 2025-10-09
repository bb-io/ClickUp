using Apps.ClickUp.Models.Request.CustomField;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.ClickUp.DataSourceHandlers.Folder;

public class FolderCustomFieldDataHandler : FolderDataHandler
{
    public FolderCustomFieldDataHandler(InvocationContext invocationContext, [ActionParameter] CustomFieldRequest request) :
        base(invocationContext, request.SpaceId)
    {
    }
}