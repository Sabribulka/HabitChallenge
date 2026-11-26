using AutoMapper;
using HabitChallenge.Domain.Entities;

namespace HabitChallenge.Application.Challenges;

public class ChallengeMappingProfile : Profile
{
    public ChallengeMappingProfile()
    {
        CreateMap<Challenge, ChallengeDto>();
    }
}