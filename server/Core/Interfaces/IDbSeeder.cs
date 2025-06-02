namespace PMS.Core.Interfaces;

public interface IDbSeeder<in TContext> where TContext : IDbContext
{
    Task SeedAsync(TContext context);
}