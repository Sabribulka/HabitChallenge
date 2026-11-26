using HabitChallenge.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HabitChallenge.Application.Common.Interfaces;

public interface IAppDbContext
{
    
    DbSet<Challenge> Challenges { get; }

    
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}