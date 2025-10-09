using Apps.ClickUp.Models.Request.CustomField;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.ClickUp.DataSourceHandlers.Space;

public class SpaceCustomFieldDataHandler : SpaceDataHandler
{
    public SpaceCustomFieldDataHandler(InvocationContext invocationContext, [ActionParameter] CustomFieldRequest request) :
        base(invocationContext, request.TeamId)
    {
    }
}