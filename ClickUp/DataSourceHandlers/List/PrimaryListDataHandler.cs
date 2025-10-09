using Apps.ClickUp.Models.Request.List;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.ClickUp.DataSourceHandlers.List;

public class PrimaryListDataHandler : ListDataHandler
{
    public PrimaryListDataHandler(InvocationContext invocationContext, [ActionParameter] ListRequest request) : base(
        invocationContext, request.FolderId)
    {
    }
}