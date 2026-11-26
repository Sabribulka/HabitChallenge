using MediatR;

namespace HabitChallenge.Application.Challenges.Queries.GetChallengeById;

public record GetChallengeByIdQuery(Guid Id) : IRequest<ChallengeDto?>;
