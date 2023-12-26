using Apps.ClickUp.Models.Entities;

namespace Apps.ClickUp.Models.Response.Group;

public record ListGroupsResponse(GroupEntity[] Groups);