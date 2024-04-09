using Apps.ClickUp.Models.Entities;

namespace Apps.ClickUp.Models.Response.Tag;

public record ListTagsResponse(TagEntity[] Tags);