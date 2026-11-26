using HabitChallenge.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace HabitChallenge.Application.Challenges.Commands.UpdateChallenge;

public class UpdateChallengeHandler(IAppDbContext db) : IRequestHandler<UpdateChallengeCommand, bool>
{
    public async Task<bool> Handle(UpdateChallengeCommand request, CancellationToken ct)
    {
        var challenge = await db.Challenges.FirstOrDefaultAsync((item) => item.Id == request.Id, ct);
        
        if (challenge == null)
        {
            return false;
        }
        
        challenge.Update(request.Title, request.Description, request.DurationDays, request.PointsReward);
        
        await db.SaveChangesAsync(ct);

        return true;
    }
}