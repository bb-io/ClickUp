using Apps.ClickUp.Utils.Converters;
using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.ClickUp.Models.Entities;

public class KeyResultEntity
{
    [Display("Key result ID")]
    public string Id { get; set; }
    
    [Display("Goal ID")]
    public string GoalId { get; set; }
    
    public string Name { get; set; }
    
    public string Type { get; set; }
    
    public string Unit { get; set; }
    
    public string Creator { get; set; }
    
    public bool Completed { get; set; }
    
    [Display("Date created")]
    [JsonConverter(typeof(UnixTimestampConverter))]
    public DateTime DateCreated { get; set; }
    
    [Display("Task IDs")]
    public IEnumerable<string> TaskIds { get; set; }


}