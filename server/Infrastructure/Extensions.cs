using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PMS.Core.Interfaces;
using PMS.Infrastructure.EFCore;

namespace PMS.Infrastructure;

public static class Extensions
{
    public static void AddNpgsqlDbContext<TContext>(this IHostApplicationBuilder builder,
                     string connectionStringName) where TContext : DbContext
    {
        var connectionString = builder.Configuration.GetConnectionString(connectionStringName);
        builder.Services.AddDbContextPool<TContext>(builder =>
        {
            builder.UseNpgsql(connectionString, npSql =>
            {
                npSql.EnableRetryOnFailure();
                npSql.CommandTimeout(30);
            });
        });
    }

    public static IServiceCollection AddMigration<TContext, TDbSeeder>(this IServiceCollection services)
    where TContext : DbContext, IDbContext
    where TDbSeeder : class, IDbSeeder<TContext>
    {
        services.AddScoped<TDbSeeder>();
        services.AddHostedService<EmployeesContextMigrationHostedService<TContext, TDbSeeder>>();
        return services;
    }
}