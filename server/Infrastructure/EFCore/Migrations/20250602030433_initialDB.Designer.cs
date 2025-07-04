﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PMS.Infrastructure.EFCore;

#nullable disable

namespace PMS.Infrastructure.EFCore.Migrations
{
    [DbContext(typeof(PMSDbContext))]
    [Migration("20250602030433_initialDB")]
    partial class initialDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Api.Data.Entities.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Speciality")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Doctors", (string)null);
                });

            modelBuilder.Entity("Api.Data.Entities.Medication", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Cost")
                        .HasColumnType("numeric(10,2)");

                    b.Property<int>("Dose")
                        .HasColumnType("integer");

                    b.Property<int>("Frequency")
                        .HasColumnType("integer")
                        .HasColumnName("integer");

                    b.Property<string>("Instruction")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsGeneric")
                        .HasColumnType("boolean");

                    b.Property<string>("MedicationName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PaitentId")
                        .HasColumnType("integer");

                    b.Property<int>("PharmacyId")
                        .HasColumnType("integer");

                    b.Property<int>("PrescriberId")
                        .HasColumnType("integer");

                    b.Property<int>("RefilAmmount")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PaitentId");

                    b.HasIndex("PharmacyId");

                    b.HasIndex("PrescriberId");

                    b.ToTable("Medications", (string)null);
                });

            modelBuilder.Entity("Api.Data.Entities.Paitent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<int?>("InsuranceId")
                        .HasColumnType("integer");

                    b.Property<bool>("IsEnsured")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Paitents", (string)null);
                });

            modelBuilder.Entity("Api.Data.Entities.Pharmacy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Pharmacies", (string)null);
                });

            modelBuilder.Entity("Api.Data.Entities.Medication", b =>
                {
                    b.HasOne("Api.Data.Entities.Paitent", "Paitent")
                        .WithMany("Medications")
                        .HasForeignKey("PaitentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Api.Data.Entities.Pharmacy", "Pharmacy")
                        .WithMany("Medications")
                        .HasForeignKey("PharmacyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Api.Data.Entities.Doctor", "Prescriber")
                        .WithMany("Medications")
                        .HasForeignKey("PrescriberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Paitent");

                    b.Navigation("Pharmacy");

                    b.Navigation("Prescriber");
                });

            modelBuilder.Entity("Api.Data.Entities.Doctor", b =>
                {
                    b.Navigation("Medications");
                });

            modelBuilder.Entity("Api.Data.Entities.Paitent", b =>
                {
                    b.Navigation("Medications");
                });

            modelBuilder.Entity("Api.Data.Entities.Pharmacy", b =>
                {
                    b.Navigation("Medications");
                });
#pragma warning restore 612, 618
        }
    }
}
