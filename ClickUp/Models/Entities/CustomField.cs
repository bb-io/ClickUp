namespace ClickUp.Models.Entities;

public class CustomField
{
    public string Id { get; set; }

    public string Name { get; set; }

    public string Type { get; set; }

    public string DateCreated { get; set; }

    public bool HideFromGuests { get; set; }

    public bool Required { get; set; }

    public List<string> Value { get; set; }
}