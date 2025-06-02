using Api.Domain.DomainServices;
using Microsoft.OpenApi.Models;
using PMS.Common.Entities;
using PMS.Core.Interfaces;
using PMS.Infrastructure;
using PMS.Infrastructure.EFCore;
using PMS.Infrastructure.EFCore.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.EnableAnnotations();
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Pharmacy Management System Api",
        Description = "Api to support Pharmacy Management System"
    });
});

var allowLocalhost = "*";
builder.Services.AddCors(options =>
{
    options.AddPolicy(allowLocalhost,
        policy => { policy.WithOrigins("*").AllowAnyHeader().AllowAnyHeader().AllowAnyOrigin(); });
});


builder.AddNpgsqlDbContext<PMSDbContext>(PMSDbContext.ConnectionStringName);
builder.Services.AddMigration<PMSDbContext, PMSContextSeed>();
builder.Services.AddScoped<IRepository<Paitent>, PaitentsRepository>();
builder.Services.AddScoped<IRepository<Medication>, MedicationsRepository>();
builder.Services.AddTransient<IPatientsService, PatientsService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.RoutePrefix = string.Empty;
    });
}

app.UseCors(allowLocalhost);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();