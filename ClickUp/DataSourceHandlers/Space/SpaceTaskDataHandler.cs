using Apps.ClickUp.Models.Request.Task;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.ClickUp.DataSourceHandlers.Space;

public class SpaceTaskDataHandler : SpaceDataHandler
{
    public SpaceTaskDataHandler(InvocationContext invocationContext, [ActionParameter] TaskRequest request) :
        base(invocationContext, request.TeamId)
    {
    }
}