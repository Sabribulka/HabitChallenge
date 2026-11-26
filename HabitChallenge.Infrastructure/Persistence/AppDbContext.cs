using HabitChallenge.Application.Common.Interfaces;
using HabitChallenge.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HabitChallenge.Infrastructure.Persistence;

public class AppDbContext : DbContext, IAppDbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions): base(dbContextOptions)
    {
    }
    
    public DbSet<Challenge> Challenges => Set<Challenge>();
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}