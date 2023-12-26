using Apps.ClickUp.Utils.Converters;
using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.ClickUp.Models.Entities;

public class GroupEntity
{
    [Display("Group ID")]
    public string Id { get; set; }
    
    [Display("Team ID")]
    public string TeamId { get; set; }
    
    public string Name { get; set; }
    
    public string Handle { get; set; }
    
    [Display("Date created")]
    [JsonConverter(typeof(UnixTimestampConverter))]
    public DateTime DateCreated { get; set; }
    
    public string Initials { get; set; }

    public IEnumerable<UserEntity> Members { get; set; }
}