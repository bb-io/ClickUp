using ClickUp.Models.Entities;

namespace ClickUp.Models.Response.Goal;

public record ListGoalsResponse(GoalEntity[] Goals);