using Api.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.EntityConfigurations;

public class PharmaciesEntityTypeConfiguration : IEntityTypeConfiguration<Pharmacy>
{
    public void Configure(EntityTypeBuilder<Pharmacy> b)
    {
        b.Property(p => p.Id)
            .ValueGeneratedOnAdd()
            .HasColumnType("integer");
        b.Property(p => p.Name)
            .HasColumnType("text");
        b.Property(p => p.State)
            .HasColumnType("text");
        b.Property(p => p.City)
            .HasColumnType("text");
        b.HasMany(p => p.Medications)
            .WithOne(p => p.Pharmacy)
            .HasForeignKey(x => x.PharmacyId);
        b.HasKey(p => p.Id);
        b.ToTable("Pharmacies");
    }
}
