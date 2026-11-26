using HabitChallenge.Application.Common.Interfaces;
using MediatR;

namespace HabitChallenge.Application.Challenges.Commands.DeleteChallenge;

public class DeleteChallengeHandler(IAppDbContext db) : IRequestHandler<DeleteChallengeCommand, bool>
{
    public async Task<bool> Handle(DeleteChallengeCommand request, CancellationToken ct)
    {
        var challenge = await db.Challenges.FindAsync([request.Id], ct);
        
        if (challenge == null)
        {
            return false;
        }

        db.Challenges.Remove(challenge);
        
        await db.SaveChangesAsync(ct);

        return true;
    }
}