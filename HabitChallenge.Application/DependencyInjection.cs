using System.Reflection;
using HabitChallenge.Application.Challenges;
using Microsoft.Extensions.DependencyInjection;

namespace HabitChallenge.Application;

public static class DependencyInjection
    
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        return services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly())).AddAutoMapper(typeof(ChallengeMappingProfile));
    }
}