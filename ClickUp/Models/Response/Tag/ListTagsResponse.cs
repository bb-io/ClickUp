using ClickUp.Models.Entities;

namespace ClickUp.Models.Response.Tag;

public record ListTagsResponse(TagEntity[] Tags);