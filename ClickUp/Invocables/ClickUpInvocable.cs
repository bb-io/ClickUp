using Apps.ClickUp.Api;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Authentication;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.ClickUp.Invocables;

public class ClickUpInvocable : BaseInvocable

{
    protected IEnumerable<AuthenticationCredentialsProvider> Creds =>
        InvocationContext.AuthenticationCredentialsProviders;

    protected ClickUpClient Client { get; }

    public ClickUpInvocable(InvocationContext invocationContext) : base(invocationContext)
    {
        Client = new();
    }
}