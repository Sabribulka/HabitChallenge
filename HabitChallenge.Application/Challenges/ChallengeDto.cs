using HabitChallenge.Domain.Enums;

namespace HabitChallenge.Application.Challenges;

public class ChallengeDto
{
    public Guid Id { get; init; }
    public string Title { get; init; } = string.Empty;
    public string Description { get; init; } = string.Empty;
    public int DurationDays { get; init; }
    public int PointsReward { get; init; }
    public ChallengeStatus Status { get;  init; }
    public DateTime CreatedAt { get; init; }
    public DateTime? UpdatedAt { get; init; }
}