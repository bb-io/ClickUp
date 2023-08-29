﻿using Blackbird.Applications.Sdk.Common;
using ClickUp.Utils.Converters;
using Newtonsoft.Json;

namespace ClickUp.Models.Entities;

public class GoalEntity
{
    [Display("Goal ID")]
    public string Id { get; set; }
    
    [Display("Team ID")]
    public string TeamId { get; set; }
    
    public string Name { get; set; }
    
    public string Color { get; set; }

    [Display("Date created")]
    [JsonConverter(typeof(UnixTimestampConverter))]
    public DateTime DateCreated { get; set; }
    
    [Display("Date updated")]
    [JsonConverter(typeof(UnixTimestampConverter))]
    public DateTime DateUpdated { get; set; }
    
    public bool Archived { get; set; }
}