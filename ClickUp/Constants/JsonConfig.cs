﻿using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Apps.ClickUp.Constants;

public static class JsonConfig
{
    public static readonly JsonSerializerSettings Settings = new()
    {
        ContractResolver = new DefaultContractResolver
        {
            NamingStrategy = new SnakeCaseNamingStrategy()
        },
        NullValueHandling = NullValueHandling.Ignore
    };
}