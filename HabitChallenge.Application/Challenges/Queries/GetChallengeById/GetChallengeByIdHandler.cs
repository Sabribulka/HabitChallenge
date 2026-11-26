using AutoMapper;
using HabitChallenge.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace HabitChallenge.Application.Challenges.Queries.GetChallengeById;

public class GetChallengeByIdHandler(IAppDbContext db, IMapper mapper): IRequestHandler<GetChallengeByIdQuery, ChallengeDto?>
{
    public async Task<ChallengeDto?> Handle(GetChallengeByIdQuery request, CancellationToken ct)
    {
        var challenge = await db.Challenges.AsNoTracking().FirstOrDefaultAsync((item) => item.Id == request.Id, ct);

        if (challenge == null)
        {
            return null;
        }

       return mapper.Map<ChallengeDto>(challenge);
    }
}