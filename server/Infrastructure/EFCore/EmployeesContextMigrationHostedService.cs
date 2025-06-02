using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PMS.Core.Interfaces;

namespace PMS.Infrastructure.EFCore;

public class EmployeesContextMigrationHostedService<TContext, TDbSeeder>(IServiceProvider serviceProvider,
                IHostEnvironment env)
    : BackgroundService where TContext : DbContext, IDbContext
                        where TDbSeeder : class, IDbSeeder<TContext>
{
    public override async Task StartAsync(CancellationToken cancellationToken)
    {
        using var scope = serviceProvider.CreateScope();
        var scopeServices = scope.ServiceProvider;
        var context = scopeServices.GetService<TContext>()
                        ?? throw new ArgumentNullException($"(nameof(EmployeesDbContext)) not found");
        var seeder = scopeServices.GetService<TDbSeeder>()
                        ?? throw new ArgumentNullException($"(nameof(EmployeesContextSeed)) not found");
        try
        {
            var strategy = context.Database.CreateExecutionStrategy();
            await strategy.ExecuteAsync(async () =>
            {
                await context.Database.MigrateAsync();
                if (!env.IsProduction())
                    await seeder.SeedAsync(context);
            });
        }
        catch (Exception)
        {
            //pass with log ??
        }
    }

    protected override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        return Task.CompletedTask;
    }
}