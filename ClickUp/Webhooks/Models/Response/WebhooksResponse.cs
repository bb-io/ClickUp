﻿using Newtonsoft.Json;

namespace ClickUp.Webhooks.Models.Response;

public class WebhooksResponse
{
    [JsonProperty("webhooks")]
    public List<Webhook> Webhooks { get; set; }
}