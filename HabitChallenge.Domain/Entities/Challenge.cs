using HabitChallenge.Domain.Enums;

namespace HabitChallenge.Domain.Entities;

public class Challenge
{
    public Guid Id { get; private set; }
    public string Title { get; private set; }
    public string Description { get; private set; }
    public int DurationDays { get; private set; }
    public int PointsReward { get; private set; }
    public ChallengeStatus Status { get;  private set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime? UpdatedAt { get; private set; }
    
    public Challenge(string title, string description,int durationDays, int pointsReward, ChallengeStatus status = ChallengeStatus.Draft)
    {
        Id = Guid.NewGuid();
        Title = title;
        Description = description;
        DurationDays = durationDays;
        PointsReward = pointsReward;
        Status = status;
        CreatedAt = DateTime.UtcNow;
    }

    public void Update(string title, string description,int durationDays, int pointsReward)
    {
        Title = title;
        Description = description;
        DurationDays = durationDays;
        PointsReward = pointsReward;
        UpdatedAt = DateTime.UtcNow;
        
    }
}