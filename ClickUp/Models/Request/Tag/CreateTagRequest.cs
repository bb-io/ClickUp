using ClickUp.Models.Entities;

namespace ClickUp.Models.Request.Tag;

public class CreateTagRequest
{
    public TagEntity Tag { get; set; }

    public CreateTagRequest(CreateTagInput input)
    {
        Tag = new()
        {
            Name = input.Name,
            TagFg = input.TagFg,
            TagBg = input.TagBg
        };
    }
}