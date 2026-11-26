using MediatR;

namespace HabitChallenge.Application.Challenges.Commands.CreateChallenge;

public record CreateChallengeCommand(string Title, string Description, int DurationDays, int PointsReward) : IRequest<Guid>;
