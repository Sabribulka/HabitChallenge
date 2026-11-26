using MediatR;

namespace HabitChallenge.Application.Challenges.Commands.UpdateChallenge;

public record UpdateChallengeCommand(Guid Id, string Title, string Description, int DurationDays, int PointsReward) : IRequest<bool>;
