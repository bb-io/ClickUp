using Apps.ClickUp.Models.Request.Space;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.ClickUp.DataSourceHandlers.Space;

public class PrimarySpaceDataHandler : SpaceDataHandler
{
    public PrimarySpaceDataHandler(InvocationContext invocationContext, [ActionParameter] SpaceRequest request) :
        base(invocationContext, request.TeamId)
    {
    }
}