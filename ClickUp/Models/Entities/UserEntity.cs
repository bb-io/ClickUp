using Blackbird.Applications.Sdk.Common;

namespace ClickUp.Models.Entities;

public class UserEntity
{
    [Display("User ID")]
    public string Id { get; set; }
    
    public string Username { get; set; }
    
    public string Email { get; set; }
    
    public string Color { get; set; }
    
    public string Initials { get; set; }
}