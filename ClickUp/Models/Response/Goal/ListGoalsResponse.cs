using Apps.ClickUp.Models.Entities;

namespace Apps.ClickUp.Models.Response.Goal;

public record ListGoalsResponse(GoalEntity[] Goals);