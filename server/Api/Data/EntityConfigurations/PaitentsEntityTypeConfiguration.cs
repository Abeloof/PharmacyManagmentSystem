using Api.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.EntityConfigurations;

class PaitentsEntityTypeConfiguration : IEntityTypeConfiguration<Paitent>
{
    public void Configure(EntityTypeBuilder<Paitent> b)
    {
        b.Property(p => p.Id)
            .ValueGeneratedOnAdd()
            .HasColumnType("integer");
        b.Property(p => p.FirstName)
            .HasColumnType("text");
        b.Property(p => p.LastName)
            .HasColumnType("text");
        b.Property(p => p.InsuranceId)
            .HasColumnType("integer");
        b.Property(p => p.IsEnsured)
            .HasColumnType("boolean");
        b.Property(p => p.DateOfBirth)
            .HasColumnType("date");
        b.HasMany(p => p.Medications)
            .WithOne(e => e.Paitent)
            .HasForeignKey(e => e.PaitentId);
        b.Navigation(p => p.Medications);
        b.HasKey(p => p.Id);
        b.ToTable("Paitents");
    }
}