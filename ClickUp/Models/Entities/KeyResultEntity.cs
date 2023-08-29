using Blackbird.Applications.Sdk.Common;
using ClickUp.Utils.Converters;
using Newtonsoft.Json;

namespace ClickUp.Models.Entities;

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