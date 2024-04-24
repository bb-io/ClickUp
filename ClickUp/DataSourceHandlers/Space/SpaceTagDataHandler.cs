using Apps.ClickUp.Models.Request.Tag;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.ClickUp.DataSourceHandlers.Space;

public class SpaceTagDataHandler : SpaceDataHandler
{
    public SpaceTagDataHandler(InvocationContext invocationContext, [ActionParameter] TagRequest request) :
        base(invocationContext, request.TeamId)
    {
    }
}