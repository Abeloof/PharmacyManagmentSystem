using Api.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.EntityConfigurations;

public class DoctorsEntityTypeConfiguration : IEntityTypeConfiguration<Doctor>
{
    public void Configure(EntityTypeBuilder<Doctor> b)
    {
        b.Property(p => p.Id)
            .ValueGeneratedOnAdd()
            .HasColumnType("integer");
        b.Property(p => p.FirstName)
            .HasColumnType("text");
        b.Property(p => p.LastName)
            .HasColumnType("text");
        b.Property(p => p.Speciality)
            .HasColumnType("text");
        b.HasMany(p => p.Medications)
            .WithOne(x => x.Prescriber)
            .HasForeignKey(x => x.PrescriberId); 
        b.HasKey(p => p.Id);
        b.ToTable("Doctors");
    }
}
