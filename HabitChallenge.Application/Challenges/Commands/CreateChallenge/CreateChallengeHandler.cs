using HabitChallenge.Application.Common.Interfaces;
using HabitChallenge.Domain.Entities;
using MediatR;

namespace HabitChallenge.Application.Challenges.Commands.CreateChallenge;

public class CreateChallengeHandler(IAppDbContext db): IRequestHandler<CreateChallengeCommand, Guid>
{
    public async Task<Guid> Handle(CreateChallengeCommand request, CancellationToken ct)
    {
        var challenge = new Challenge(request.Title, request.Description, request.DurationDays, request.PointsReward);
        
        db.Challenges.Add(challenge);
        await db.SaveChangesAsync(ct);

        return challenge.Id;
    }
}