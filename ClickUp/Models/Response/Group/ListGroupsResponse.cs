using ClickUp.Models.Entities;

namespace ClickUp.Models.Response.Group;

public record ListGroupsResponse(GroupEntity[] Groups);