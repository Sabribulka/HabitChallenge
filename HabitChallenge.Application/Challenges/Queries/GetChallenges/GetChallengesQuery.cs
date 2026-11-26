using MediatR;

namespace HabitChallenge.Application.Challenges.Queries.GetChallenges;

public record GetChallengesQuery : IRequest<List<ChallengeDto>>;
