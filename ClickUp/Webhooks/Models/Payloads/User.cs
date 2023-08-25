﻿using Blackbird.Applications.Sdk.Common;

namespace ClickUp.Webhooks.Models.Payloads;

public class User
{
    [Display("ID")]
    public string Id { get; set; }

    public string Username { get; set; }
    
    public string Email { get; set; }

    public string Color { get; set; }

    public string Initials { get; set; }

    [Display("Profile picture")]
    public object ProfilePicture { get; set; }
}