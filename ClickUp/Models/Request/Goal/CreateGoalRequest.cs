﻿using Apps.ClickUp.Utils.Converters;
using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.ClickUp.Models.Request.Goal;

public class CreateGoalRequest
{
    public string Name { get; set; }
    
    public string? Description { get; set; }
    
    public string? Color { get; set; }
    
    public IEnumerable<string>? Owners { get; set; }
    
    [Display("Multiple owners")]
    public bool? MultipleOwners { get; set; }
    
    [Display("Due date")]
    [JsonConverter(typeof(UnixTimestampConverter))] 
    public DateTime? DueDate { get; set; }
}