using Apps.ClickUp.Constants;
using Apps.ClickUp.Models.Request.Task;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;
using Blackbird.Applications.Sdk.Utils.Extensions.Sdk;

namespace Apps.ClickUp.DataSourceHandlers.Space;

public class SpaceTaskDataHandler : SpaceDataHandler
{
    public SpaceTaskDataHandler(InvocationContext invocationContext, [ActionParameter] TaskRequest request) :
        base(invocationContext, invocationContext.AuthenticationCredentialsProviders.Get(CredsNames.Team).Value)
    {
    }
}