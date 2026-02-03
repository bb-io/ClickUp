using Apps.ClickUp.Constants;
using Blackbird.Applications.Sdk.Common.Exceptions;
using Blackbird.Applications.Sdk.Common.Invocation;
using Blackbird.Applications.Sdk.Utils.Extensions.Sdk;

namespace Apps.ClickUp.Utils;

public static class CredsProvider
{
    public static string GetTeamId(this InvocationContext ctx)
   => ctx.AuthenticationCredentialsProviders.GetRequiredValue(CredsNames.Team, "Team ID");

    public static string GetSpaceId(this InvocationContext ctx)
        => ctx.AuthenticationCredentialsProviders.GetRequiredValue(CredsNames.Space, "Space ID");

    private static string GetRequiredValue(
        this IEnumerable<Blackbird.Applications.Sdk.Common.Authentication.AuthenticationCredentialsProvider> creds,
        string credName,
        string displayName)
    {
        try
        {
            var value = creds.Get(credName)?.Value;
            if (string.IsNullOrWhiteSpace(value))
                throw new PluginMisconfigurationException(
                    $"'{displayName}' is missing in the connection settings. Please re-connect and select '{displayName}'.");

            return value!;
        }
        catch
        {
            throw new PluginMisconfigurationException(
                $"'{displayName}' is missing in the connection settings. Please re-connect and select '{displayName}'.");
        }
    }
}

