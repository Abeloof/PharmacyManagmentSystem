using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PMS.Common.Entities;

namespace PMS.Infrastructure.EFCore.EntityConfigurations;

public class MedicationEntityTypeConfiguration : IEntityTypeConfiguration<Medication>
{
    public void Configure(EntityTypeBuilder<Medication> b)
    {
        b.Property(p => p.Id)
            .ValueGeneratedOnAdd()
            .HasColumnType("integer");
        b.Property(p => p.RefilAmmount)
            .HasColumnType("integer");
        b.Property(p => p.IsGeneric)
            .HasColumnType("boolean");
        b.Property(p => p.Cost)
            .HasColumnType("numeric(10,2)");
        b.Property(p => p.Dose)
            .HasColumnType("integer");
        b.Property(p => p.Instruction)
            .HasColumnType("text");
        b.Property(p => p.MedicationName)
            .HasColumnType("text");
        b.Property(p => p.Frequency)
            .HasColumnName("integer");
        b.Navigation(p => p.Paitent);
        b.Navigation(p => p.Pharmacy);
        b.Navigation(p => p.Prescriber);
        b.HasKey(p => p.Id);
        b.ToTable("Medications");
    }
}
