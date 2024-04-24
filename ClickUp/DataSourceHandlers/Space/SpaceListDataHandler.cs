using Apps.ClickUp.Models.Request.List;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.ClickUp.DataSourceHandlers.Space;

public class SpaceListDataHandler : SpaceDataHandler
{
    public SpaceListDataHandler(InvocationContext invocationContext, [ActionParameter] ListRequest request) :
        base(invocationContext, request.TeamId)
    {
    }
}