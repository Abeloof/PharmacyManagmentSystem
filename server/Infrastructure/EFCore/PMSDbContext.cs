using Microsoft.EntityFrameworkCore;
using PMS.Common.Entities;
using PMS.Core.Interfaces;
using PMS.Infrastructure.EFCore.EntityConfigurations;

namespace PMS.Infrastructure.EFCore;

/// init migrations: dotnet ef migrations add --context EmployeesDbContext initial -n Data.Migrations
public class PMSDbContext(DbContextOptions<PMSDbContext> options) : DbContext(options), IDbContext 
{
    public const string ConnectionStringName = "PharmacyManagmentSystemDB";
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Medication> Medications { get; set; }
    public DbSet<Paitent> Paitents { get; set; }
    public DbSet<Pharmacy> Pharmacies { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new DoctorsEntityTypeConfiguration());
        builder.ApplyConfiguration(new PaitentsEntityTypeConfiguration());
        builder.ApplyConfiguration(new MedicationEntityTypeConfiguration());
        builder.ApplyConfiguration(new PharmaciesEntityTypeConfiguration());
    }
}

