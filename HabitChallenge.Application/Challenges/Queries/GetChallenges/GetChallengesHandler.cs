using AutoMapper;
using AutoMapper.QueryableExtensions;
using HabitChallenge.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace HabitChallenge.Application.Challenges.Queries.GetChallenges;

public class GetChallengesHandler(IAppDbContext db, IMapper mapper): IRequestHandler<GetChallengesQuery, List<ChallengeDto>>
{
    public async Task<List<ChallengeDto>> Handle(GetChallengesQuery request, CancellationToken ct)
    {
        return await db.Challenges.ProjectTo<ChallengeDto>(mapper.ConfigurationProvider).ToListAsync(ct);
    }
}