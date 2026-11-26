using MediatR;

namespace HabitChallenge.Application.Challenges.Commands.DeleteChallenge;

public record DeleteChallengeCommand(Guid Id) : IRequest<bool>;
