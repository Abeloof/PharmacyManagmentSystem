using Api.Data;
using Api.Data.Entities;
using Api.Data.Repository;
using Api.Domain.DomainServices;
using Api.Domain.Interfaces;
using Microsoft.OpenApi.Models;

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
// builder.Services.Configure<EarningsOptions>(
//     builder.Configuration.GetSection(EarningsOptions.Earnings)
// );
// builder.Services.AddSingleton(TimeProvider.System);
// builder.Services.AddTransient<IEarningsCalculator, EarningsCalulator>();
// builder.Services.AddTransient<IEarningPeriodDeduction, DependentsDeduction>();
// builder.Services.AddTransient<IEarningPeriodDeduction, DependentsOver50Deduction>();
// builder.Services.AddTransient<IEarningPeriodDeduction, EmployedDeduction>();
// builder.Services.AddTransient<IEarningPeriodDeduction, SalaryBasedDeduction>();
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