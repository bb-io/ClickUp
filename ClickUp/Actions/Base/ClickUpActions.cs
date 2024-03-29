﻿using Apps.ClickUp.Api;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Authentication;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.ClickUp.Actions.Base;

public class ClickUpActions : BaseInvocable
{
    protected IEnumerable<AuthenticationCredentialsProvider> Creds =>
        InvocationContext.AuthenticationCredentialsProviders;
    
    protected ClickUpClient Client { get; }
    
    public ClickUpActions(InvocationContext invocationContext) : base(invocationContext)
    {
        Client = new();
    }
}