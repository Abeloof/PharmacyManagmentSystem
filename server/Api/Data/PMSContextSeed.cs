using Api.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Data;

public interface IDbSeeder<in TContext> where TContext : DbContext
{
    Task SeedAsync(TContext context);
}

public class PMSContextSeed : IDbSeeder<PMSDbContext>
{
    public async Task SeedAsync(PMSDbContext context)
    {
        try
        {
            context.Doctors.RemoveRange(context.Doctors);
            context.Pharmacies.RemoveRange(context.Pharmacies);
            context.Medications.RemoveRange(context.Medications);
            context.Paitents.RemoveRange(context.Paitents);
            context.Paitents.AddRange(new List<Paitent>
            {
                new Paitent() {
                    FirstName = "Ja",
                    LastName = "Morant",
                    InsuranceId = 12,
                    IsEnsured = true,
                    DateOfBirth = new DateTime(1999, 8, 10),
                    Medications = new List<Medication>(){
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 1",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 1",
                                Name = "Pharm 1",
                                State = "state 1"
                            },
                            Dose = 10,
                            Frequency = 3,
                            Instruction = "Take 1 after breakfast, launch and dinner",
                            RefilAmmount = 2,
                            Cost = 300,
                            IsGeneric = false,
                            MedicationName = "Med1"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 2",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 2",
                                Name = "Pharm 2",
                                State = "state 2"
                            },
                            Dose = 100,
                            Frequency = 3,
                            Instruction = "Take 2 pills after breakfast, launch and dinner",
                            RefilAmmount = 2
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 3",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 3",
                                Name = "Pharm 3",
                                State = "state 3"
                            },
                            Dose = 100,
                            Frequency = 3,
                            Instruction = "Take 3 pills after breakfast, launch and dinner",
                            RefilAmmount = 5
                        }
                    }
                },
                new Paitent() {
                    FirstName = "Ja",
                    LastName = "Morant",
                    InsuranceId = 166,
                    IsEnsured = true,
                    DateOfBirth = new DateTime(1967, 8, 10),
                    Medications = new List<Medication>(){
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 1",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 1",
                                Name = "Pharm 1",
                                State = "state 1"
                            },
                            Dose = 10,
                            Frequency = 3,
                            Instruction = "Take 1 after breakfast, launch and dinner",
                            RefilAmmount = 2,
                            Cost = 1400,
                            IsGeneric = false,
                            MedicationName = "mz"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 2",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 2",
                                Name = "Pharm 2",
                                State = "state 2"
                            },
                            Dose = 100,
                            Frequency = 3,
                            Instruction = "Take 2 pills after breakfast, launch and dinner",
                            RefilAmmount = 2,
                            Cost = 800,
                            IsGeneric = false,
                            MedicationName = "Med9"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 3",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 3",
                                Name = "Pharm 3",
                                State = "state 3"
                            },
                            Dose = 100,
                            Frequency = 3,
                            Instruction = "Take 3 pills after breakfast, launch and dinner",
                            RefilAmmount = 5,
                            Cost = 300,
                            IsGeneric = true,
                            MedicationName = "Med6"
                        }
                    }
                },
                new Paitent() {
                    FirstName = "Tabitha",
                    LastName = "Jones",
                    InsuranceId = 16786,
                    IsEnsured = true,
                    DateOfBirth = new DateTime(1967, 8, 10),
                    Medications = new List<Medication>(){
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 1",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 1",
                                Name = "Pharm 1",
                                State = "state 1"
                            },
                            Dose = 10,
                            Frequency = 3,
                            Instruction = "Take 1 after breakfast, launch and dinner",
                            RefilAmmount = 2,
                            Cost = 100,
                            IsGeneric = true,
                            MedicationName = "Med7"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 2",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 2",
                                Name = "Pharm 2",
                                State = "state 2"
                            },
                            Dose = 100,
                            Frequency = 3,
                            Instruction = "Take 2 pills after breakfast, launch and dinner",
                            RefilAmmount = 2,
                            Cost = 1000,
                            IsGeneric = true,
                            MedicationName = "Med"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 3",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 3",
                                Name = "Pharm 3",
                                State = "state 3"
                            },
                            Dose = 100,
                            Frequency = 3,
                            Instruction = "Take 3 pills after breakfast, launch and dinner",
                            RefilAmmount = 5,
                            Cost = 1000,
                            IsGeneric = true,
                            MedicationName = "Med9"
                        }
                    }
                },
                new Paitent() {
                    FirstName = "Mike",
                    LastName = "Jones",
                    IsEnsured = false,
                    DateOfBirth = new DateTime(1967, 8, 10),
                    Medications = new List<Medication>(){
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 1",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 1",
                                Name = "Pharm 1",
                                State = "state 1"
                            },
                            Dose = 10,
                            Frequency = 3,
                            Instruction = "Take 1 after breakfast, launch and dinner",
                            RefilAmmount = 2,
                            Cost = 100,
                            IsGeneric = true,
                            MedicationName = "Med7"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 2",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 2",
                                Name = "Pharm 2",
                                State = "state 2"
                            },
                            Dose = 100,
                            Frequency = 3,
                            Instruction = "Take 2 pills after breakfast, launch and dinner",
                            RefilAmmount = 2,
                            Cost = 1000,
                            IsGeneric = true,
                            MedicationName = "Med"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 3",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 3",
                                Name = "Pharm 3",
                                State = "state 3"
                            },
                            Dose = 100,
                            Frequency = 3,
                            Instruction = "Take 3 pills after breakfast, launch and dinner",
                            RefilAmmount = 5,
                            Cost = 1000,
                            IsGeneric = true,
                            MedicationName = "Med9"
                        }
                    }
                },
                new Paitent() {
                    FirstName = "Tatha",
                    LastName = "Ones",
                    IsEnsured = false,
                    DateOfBirth = new DateTime(1967, 8, 10),
                    Medications = new List<Medication>(){
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 1",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 1",
                                Name = "Pharm 1",
                                State = "state 1"
                            },
                            Dose = 10,
                            Frequency = 3,
                            Instruction = "Take 1 after breakfast, launch and dinner",
                            RefilAmmount = 2,
                            Cost = 100,
                            IsGeneric = true,
                            MedicationName = "Med7"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 2",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 2",
                                Name = "Pharm 2",
                                State = "state 2"
                            },
                            Dose = 100,
                            Frequency = 3,
                            Instruction = "Take 2 pills after breakfast, launch and dinner",
                            RefilAmmount = 2,
                            Cost = 1000,
                            IsGeneric = true,
                            MedicationName = "Med"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 3",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 3",
                                Name = "Pharm 3",
                                State = "state 3"
                            },
                            Dose = 100,
                            Frequency = 3,
                            Instruction = "Take 3 pills after breakfast, launch and dinner",
                            RefilAmmount = 5,
                            Cost = 1000,
                            IsGeneric = true,
                            MedicationName = "Med9"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 3",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 3",
                                Name = "Pharm 3",
                                State = "state 3"
                            },
                            Dose = 1008,
                            Frequency = 3,
                            Instruction = "Take 3 pills after breakfast, launch and dinner",
                            RefilAmmount = 5,
                            Cost = 160,
                            IsGeneric = true,
                            MedicationName = "Med9"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 3",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 3",
                                Name = "Pharm 3",
                                State = "state 3"
                            },
                            Dose = 1008,
                            Frequency = 3,
                            Instruction = "Take 3 pills after breakfast, launch and dinner",
                            RefilAmmount = 5,
                            Cost = 140,
                            IsGeneric = false,
                            MedicationName = "Med9"
                        }
                    }
                },
                new Paitent() {
                    FirstName = "Tatha",
                    LastName = "Ones",
                    IsEnsured = false,
                    DateOfBirth = new DateTime(1967, 8, 10),
                    Medications = new List<Medication>(){
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 1",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 1",
                                Name = "Pharm 1",
                                State = "state 1"
                            },
                            Dose = 10,
                            Frequency = 3,
                            Instruction = "Take 1 after breakfast, launch and dinner",
                            RefilAmmount = 2,
                            Cost = 100,
                            IsGeneric = true,
                            MedicationName = "Med7"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 2",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 2",
                                Name = "Pharm 2",
                                State = "state 2"
                            },
                            Dose = 100,
                            Frequency = 3,
                            Instruction = "Take 2 pills after breakfast, launch and dinner",
                            RefilAmmount = 2,
                            Cost = 1000,
                            IsGeneric = true,
                            MedicationName = "Med"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 3",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 3",
                                Name = "Pharm 3",
                                State = "state 3"
                            },
                            Dose = 100,
                            Frequency = 3,
                            Instruction = "Take 3 pills after breakfast, launch and dinner",
                            RefilAmmount = 5,
                            Cost = 1000,
                            IsGeneric = true,
                            MedicationName = "Med9"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 3",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 3",
                                Name = "Pharm 3",
                                State = "state 3"
                            },
                            Dose = 1008,
                            Frequency = 3,
                            Instruction = "Take 3 pills after breakfast, launch and dinner",
                            RefilAmmount = 5,
                            Cost = 160,
                            IsGeneric = true,
                            MedicationName = "Med9"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 3",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 3",
                                Name = "Pharm 3",
                                State = "state 3"
                            },
                            Dose = 1008,
                            Frequency = 3,
                            Instruction = "Take 3 pills after breakfast, launch and dinner",
                            RefilAmmount = 5,
                            Cost = 140,
                            IsGeneric = false,
                            MedicationName = "Med9"
                        }
                    }
                },
                new Paitent() {
                    FirstName = "Tatha",
                    LastName = "Ones",
                    IsEnsured = false,
                    DateOfBirth = new DateTime(1967, 8, 10),
                    Medications = new List<Medication>(){
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 1",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 1",
                                Name = "Pharm 1",
                                State = "state 1"
                            },
                            Dose = 10,
                            Frequency = 3,
                            Instruction = "Take 1 after breakfast, launch and dinner",
                            RefilAmmount = 2,
                            Cost = 100,
                            IsGeneric = true,
                            MedicationName = "Med7"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 2",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 2",
                                Name = "Pharm 2",
                                State = "state 2"
                            },
                            Dose = 100,
                            Frequency = 3,
                            Instruction = "Take 2 pills after breakfast, launch and dinner",
                            RefilAmmount = 2,
                            Cost = 1000,
                            IsGeneric = true,
                            MedicationName = "Med"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 3",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 3",
                                Name = "Pharm 3",
                                State = "state 3"
                            },
                            Dose = 100,
                            Frequency = 3,
                            Instruction = "Take 3 pills after breakfast, launch and dinner",
                            RefilAmmount = 5,
                            Cost = 1000,
                            IsGeneric = true,
                            MedicationName = "Med9"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 3",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 3",
                                Name = "Pharm 3",
                                State = "state 3"
                            },
                            Dose = 1008,
                            Frequency = 3,
                            Instruction = "Take 3 pills after breakfast, launch and dinner",
                            RefilAmmount = 5,
                            Cost = 160,
                            IsGeneric = true,
                            MedicationName = "Med9"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 3",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 3",
                                Name = "Pharm 3",
                                State = "state 3"
                            },
                            Dose = 1008,
                            Frequency = 3,
                            Instruction = "Take 3 pills after breakfast, launch and dinner",
                            RefilAmmount = 5,
                            Cost = 140,
                            IsGeneric = false,
                            MedicationName = "Med9"
                        }
                    }
                },
                new Paitent() {
                    FirstName = "Tatha",
                    LastName = "Ones",
                    IsEnsured = false,
                    DateOfBirth = new DateTime(1967, 8, 10),
                    Medications = new List<Medication>(){
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 1",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 1",
                                Name = "Pharm 1",
                                State = "state 1"
                            },
                            Dose = 10,
                            Frequency = 3,
                            Instruction = "Take 1 after breakfast, launch and dinner",
                            RefilAmmount = 2,
                            Cost = 100,
                            IsGeneric = true,
                            MedicationName = "Med7"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 2",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 2",
                                Name = "Pharm 2",
                                State = "state 2"
                            },
                            Dose = 100,
                            Frequency = 3,
                            Instruction = "Take 2 pills after breakfast, launch and dinner",
                            RefilAmmount = 2,
                            Cost = 1000,
                            IsGeneric = true,
                            MedicationName = "Med"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 3",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 3",
                                Name = "Pharm 3",
                                State = "state 3"
                            },
                            Dose = 100,
                            Frequency = 3,
                            Instruction = "Take 3 pills after breakfast, launch and dinner",
                            RefilAmmount = 5,
                            Cost = 1000,
                            IsGeneric = true,
                            MedicationName = "Med9"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 3",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 3",
                                Name = "Pharm 3",
                                State = "state 3"
                            },
                            Dose = 1008,
                            Frequency = 3,
                            Instruction = "Take 3 pills after breakfast, launch and dinner",
                            RefilAmmount = 5,
                            Cost = 160,
                            IsGeneric = true,
                            MedicationName = "Med9"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 3",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 3",
                                Name = "Pharm 3",
                                State = "state 3"
                            },
                            Dose = 1008,
                            Frequency = 3,
                            Instruction = "Take 3 pills after breakfast, launch and dinner",
                            RefilAmmount = 5,
                            Cost = 140,
                            IsGeneric = false,
                            MedicationName = "Med9"
                        }
                    }
                },
                new Paitent() {
                    FirstName = "Tatha",
                    LastName = "Ones",
                    IsEnsured = false,
                    DateOfBirth = new DateTime(1967, 8, 10),
                    Medications = new List<Medication>(){
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 1",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 1",
                                Name = "Pharm 1",
                                State = "state 1"
                            },
                            Dose = 10,
                            Frequency = 3,
                            Instruction = "Take 1 after breakfast, launch and dinner",
                            RefilAmmount = 2,
                            Cost = 100,
                            IsGeneric = true,
                            MedicationName = "Med7"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 2",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 2",
                                Name = "Pharm 2",
                                State = "state 2"
                            },
                            Dose = 100,
                            Frequency = 3,
                            Instruction = "Take 2 pills after breakfast, launch and dinner",
                            RefilAmmount = 2,
                            Cost = 1000,
                            IsGeneric = true,
                            MedicationName = "Med"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 3",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 3",
                                Name = "Pharm 3",
                                State = "state 3"
                            },
                            Dose = 100,
                            Frequency = 3,
                            Instruction = "Take 3 pills after breakfast, launch and dinner",
                            RefilAmmount = 5,
                            Cost = 1000,
                            IsGeneric = true,
                            MedicationName = "Med9"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 3",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 3",
                                Name = "Pharm 3",
                                State = "state 3"
                            },
                            Dose = 1008,
                            Frequency = 3,
                            Instruction = "Take 3 pills after breakfast, launch and dinner",
                            RefilAmmount = 5,
                            Cost = 160,
                            IsGeneric = true,
                            MedicationName = "Med9"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 3",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 3",
                                Name = "Pharm 3",
                                State = "state 3"
                            },
                            Dose = 1008,
                            Frequency = 3,
                            Instruction = "Take 3 pills after breakfast, launch and dinner",
                            RefilAmmount = 5,
                            Cost = 140,
                            IsGeneric = false,
                            MedicationName = "Med9"
                        }
                    }
                },
                new Paitent() {
                    FirstName = "Tatha",
                    LastName = "Ones",
                    IsEnsured = false,
                    DateOfBirth = new DateTime(1967, 8, 10),
                    Medications = new List<Medication>(){
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 1",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 1",
                                Name = "Pharm 1",
                                State = "state 1"
                            },
                            Dose = 10,
                            Frequency = 3,
                            Instruction = "Take 1 after breakfast, launch and dinner",
                            RefilAmmount = 2,
                            Cost = 100,
                            IsGeneric = true,
                            MedicationName = "Med7"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 2",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 2",
                                Name = "Pharm 2",
                                State = "state 2"
                            },
                            Dose = 100,
                            Frequency = 3,
                            Instruction = "Take 2 pills after breakfast, launch and dinner",
                            RefilAmmount = 2,
                            Cost = 1000,
                            IsGeneric = true,
                            MedicationName = "Med"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 3",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 3",
                                Name = "Pharm 3",
                                State = "state 3"
                            },
                            Dose = 100,
                            Frequency = 3,
                            Instruction = "Take 3 pills after breakfast, launch and dinner",
                            RefilAmmount = 5,
                            Cost = 1000,
                            IsGeneric = true,
                            MedicationName = "Med9"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 3",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 3",
                                Name = "Pharm 3",
                                State = "state 3"
                            },
                            Dose = 1008,
                            Frequency = 3,
                            Instruction = "Take 3 pills after breakfast, launch and dinner",
                            RefilAmmount = 5,
                            Cost = 160,
                            IsGeneric = true,
                            MedicationName = "Med9"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 3",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 3",
                                Name = "Pharm 3",
                                State = "state 3"
                            },
                            Dose = 1008,
                            Frequency = 3,
                            Instruction = "Take 3 pills after breakfast, launch and dinner",
                            RefilAmmount = 5,
                            Cost = 140,
                            IsGeneric = false,
                            MedicationName = "Med9"
                        }
                    }
                },
                new Paitent() {
                    FirstName = "Tatha",
                    LastName = "Ones",
                    IsEnsured = false,
                    DateOfBirth = new DateTime(1967, 8, 10),
                    Medications = new List<Medication>(){
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 1",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 1",
                                Name = "Pharm 1",
                                State = "state 1"
                            },
                            Dose = 10,
                            Frequency = 3,
                            Instruction = "Take 1 after breakfast, launch and dinner",
                            RefilAmmount = 2,
                            Cost = 100,
                            IsGeneric = true,
                            MedicationName = "Med7"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 2",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 2",
                                Name = "Pharm 2",
                                State = "state 2"
                            },
                            Dose = 100,
                            Frequency = 3,
                            Instruction = "Take 2 pills after breakfast, launch and dinner",
                            RefilAmmount = 2,
                            Cost = 1000,
                            IsGeneric = true,
                            MedicationName = "Med"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 3",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 3",
                                Name = "Pharm 3",
                                State = "state 3"
                            },
                            Dose = 100,
                            Frequency = 3,
                            Instruction = "Take 3 pills after breakfast, launch and dinner",
                            RefilAmmount = 5,
                            Cost = 1000,
                            IsGeneric = true,
                            MedicationName = "Med9"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 3",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 3",
                                Name = "Pharm 3",
                                State = "state 3"
                            },
                            Dose = 1008,
                            Frequency = 3,
                            Instruction = "Take 3 pills after breakfast, launch and dinner",
                            RefilAmmount = 5,
                            Cost = 160,
                            IsGeneric = true,
                            MedicationName = "Med9"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 3",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 3",
                                Name = "Pharm 3",
                                State = "state 3"
                            },
                            Dose = 1008,
                            Frequency = 3,
                            Instruction = "Take 3 pills after breakfast, launch and dinner",
                            RefilAmmount = 5,
                            Cost = 140,
                            IsGeneric = false,
                            MedicationName = "Med9"
                        }
                    }
                },
                new Paitent() {
                    FirstName = "Tatha",
                    LastName = "Ones",
                    IsEnsured = false,
                    DateOfBirth = new DateTime(1967, 8, 10),
                    Medications = new List<Medication>(){
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 1",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 1",
                                Name = "Pharm 1",
                                State = "state 1"
                            },
                            Dose = 10,
                            Frequency = 3,
                            Instruction = "Take 1 after breakfast, launch and dinner",
                            RefilAmmount = 2,
                            Cost = 100,
                            IsGeneric = true,
                            MedicationName = "Med7"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 2",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 2",
                                Name = "Pharm 2",
                                State = "state 2"
                            },
                            Dose = 100,
                            Frequency = 3,
                            Instruction = "Take 2 pills after breakfast, launch and dinner",
                            RefilAmmount = 2,
                            Cost = 1000,
                            IsGeneric = true,
                            MedicationName = "Med"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 3",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 3",
                                Name = "Pharm 3",
                                State = "state 3"
                            },
                            Dose = 100,
                            Frequency = 3,
                            Instruction = "Take 3 pills after breakfast, launch and dinner",
                            RefilAmmount = 5,
                            Cost = 1000,
                            IsGeneric = true,
                            MedicationName = "Med9"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 3",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 3",
                                Name = "Pharm 3",
                                State = "state 3"
                            },
                            Dose = 1008,
                            Frequency = 3,
                            Instruction = "Take 3 pills after breakfast, launch and dinner",
                            RefilAmmount = 5,
                            Cost = 160,
                            IsGeneric = true,
                            MedicationName = "Med9"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 3",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 3",
                                Name = "Pharm 3",
                                State = "state 3"
                            },
                            Dose = 1008,
                            Frequency = 3,
                            Instruction = "Take 3 pills after breakfast, launch and dinner",
                            RefilAmmount = 5,
                            Cost = 140,
                            IsGeneric = false,
                            MedicationName = "Med9"
                        }
                    }
                },
                new Paitent() {
                    FirstName = "Tatha",
                    LastName = "Ones",
                    IsEnsured = false,
                    DateOfBirth = new DateTime(1967, 8, 10),
                    Medications = new List<Medication>(){
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 1",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 1",
                                Name = "Pharm 1",
                                State = "state 1"
                            },
                            Dose = 10,
                            Frequency = 3,
                            Instruction = "Take 1 after breakfast, launch and dinner",
                            RefilAmmount = 2,
                            Cost = 100,
                            IsGeneric = true,
                            MedicationName = "Med7"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 2",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 2",
                                Name = "Pharm 2",
                                State = "state 2"
                            },
                            Dose = 100,
                            Frequency = 3,
                            Instruction = "Take 2 pills after breakfast, launch and dinner",
                            RefilAmmount = 2,
                            Cost = 1000,
                            IsGeneric = true,
                            MedicationName = "Med"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 3",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 3",
                                Name = "Pharm 3",
                                State = "state 3"
                            },
                            Dose = 100,
                            Frequency = 3,
                            Instruction = "Take 3 pills after breakfast, launch and dinner",
                            RefilAmmount = 5,
                            Cost = 1000,
                            IsGeneric = true,
                            MedicationName = "Med9"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 3",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 3",
                                Name = "Pharm 3",
                                State = "state 3"
                            },
                            Dose = 1008,
                            Frequency = 3,
                            Instruction = "Take 3 pills after breakfast, launch and dinner",
                            RefilAmmount = 5,
                            Cost = 160,
                            IsGeneric = true,
                            MedicationName = "Med9"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 3",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 3",
                                Name = "Pharm 3",
                                State = "state 3"
                            },
                            Dose = 1008,
                            Frequency = 3,
                            Instruction = "Take 3 pills after breakfast, launch and dinner",
                            RefilAmmount = 5,
                            Cost = 140,
                            IsGeneric = false,
                            MedicationName = "Med9"
                        }
                    }
                },
                new Paitent() {
                    FirstName = "Tatha",
                    LastName = "Ones",
                    IsEnsured = false,
                    DateOfBirth = new DateTime(1967, 8, 10),
                    Medications = new List<Medication>(){
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 1",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 1",
                                Name = "Pharm 1",
                                State = "state 1"
                            },
                            Dose = 10,
                            Frequency = 3,
                            Instruction = "Take 1 after breakfast, launch and dinner",
                            RefilAmmount = 2,
                            Cost = 100,
                            IsGeneric = true,
                            MedicationName = "Med7"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 2",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 2",
                                Name = "Pharm 2",
                                State = "state 2"
                            },
                            Dose = 100,
                            Frequency = 3,
                            Instruction = "Take 2 pills after breakfast, launch and dinner",
                            RefilAmmount = 2,
                            Cost = 1000,
                            IsGeneric = true,
                            MedicationName = "Med"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 3",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 3",
                                Name = "Pharm 3",
                                State = "state 3"
                            },
                            Dose = 100,
                            Frequency = 3,
                            Instruction = "Take 3 pills after breakfast, launch and dinner",
                            RefilAmmount = 5,
                            Cost = 1000,
                            IsGeneric = true,
                            MedicationName = "Med9"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 3",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 3",
                                Name = "Pharm 3",
                                State = "state 3"
                            },
                            Dose = 1008,
                            Frequency = 3,
                            Instruction = "Take 3 pills after breakfast, launch and dinner",
                            RefilAmmount = 5,
                            Cost = 160,
                            IsGeneric = true,
                            MedicationName = "Med9"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 3",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 3",
                                Name = "Pharm 3",
                                State = "state 3"
                            },
                            Dose = 1008,
                            Frequency = 3,
                            Instruction = "Take 3 pills after breakfast, launch and dinner",
                            RefilAmmount = 5,
                            Cost = 140,
                            IsGeneric = false,
                            MedicationName = "Med9"
                        }
                    }
                },
                new Paitent() {
                    FirstName = "Tatha",
                    LastName = "Ones",
                    IsEnsured = false,
                    DateOfBirth = new DateTime(1967, 8, 10),
                    Medications = new List<Medication>(){
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 1",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 1",
                                Name = "Pharm 1",
                                State = "state 1"
                            },
                            Dose = 10,
                            Frequency = 3,
                            Instruction = "Take 1 after breakfast, launch and dinner",
                            RefilAmmount = 2,
                            Cost = 100,
                            IsGeneric = true,
                            MedicationName = "Med7"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 2",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 2",
                                Name = "Pharm 2",
                                State = "state 2"
                            },
                            Dose = 100,
                            Frequency = 3,
                            Instruction = "Take 2 pills after breakfast, launch and dinner",
                            RefilAmmount = 2,
                            Cost = 1000,
                            IsGeneric = true,
                            MedicationName = "Med"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 3",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 3",
                                Name = "Pharm 3",
                                State = "state 3"
                            },
                            Dose = 100,
                            Frequency = 3,
                            Instruction = "Take 3 pills after breakfast, launch and dinner",
                            RefilAmmount = 5,
                            Cost = 1000,
                            IsGeneric = true,
                            MedicationName = "Med9"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 3",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 3",
                                Name = "Pharm 3",
                                State = "state 3"
                            },
                            Dose = 1008,
                            Frequency = 3,
                            Instruction = "Take 3 pills after breakfast, launch and dinner",
                            RefilAmmount = 5,
                            Cost = 160,
                            IsGeneric = true,
                            MedicationName = "Med9"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 3",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 3",
                                Name = "Pharm 3",
                                State = "state 3"
                            },
                            Dose = 1008,
                            Frequency = 3,
                            Instruction = "Take 3 pills after breakfast, launch and dinner",
                            RefilAmmount = 5,
                            Cost = 140,
                            IsGeneric = false,
                            MedicationName = "Med9"
                        }
                    }
                },
                new Paitent() {
                    FirstName = "Tatha",
                    LastName = "Ones",
                    IsEnsured = false,
                    DateOfBirth = new DateTime(1967, 8, 10),
                    Medications = new List<Medication>(){
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 1",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 1",
                                Name = "Pharm 1",
                                State = "state 1"
                            },
                            Dose = 10,
                            Frequency = 3,
                            Instruction = "Take 1 after breakfast, launch and dinner",
                            RefilAmmount = 2,
                            Cost = 100,
                            IsGeneric = true,
                            MedicationName = "Med7"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 2",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 2",
                                Name = "Pharm 2",
                                State = "state 2"
                            },
                            Dose = 100,
                            Frequency = 3,
                            Instruction = "Take 2 pills after breakfast, launch and dinner",
                            RefilAmmount = 2,
                            Cost = 1000,
                            IsGeneric = true,
                            MedicationName = "Med"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 3",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 3",
                                Name = "Pharm 3",
                                State = "state 3"
                            },
                            Dose = 100,
                            Frequency = 3,
                            Instruction = "Take 3 pills after breakfast, launch and dinner",
                            RefilAmmount = 5,
                            Cost = 1000,
                            IsGeneric = true,
                            MedicationName = "Med9"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 3",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 3",
                                Name = "Pharm 3",
                                State = "state 3"
                            },
                            Dose = 1008,
                            Frequency = 3,
                            Instruction = "Take 3 pills after breakfast, launch and dinner",
                            RefilAmmount = 5,
                            Cost = 160,
                            IsGeneric = true,
                            MedicationName = "Med9"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 3",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 3",
                                Name = "Pharm 3",
                                State = "state 3"
                            },
                            Dose = 1008,
                            Frequency = 3,
                            Instruction = "Take 3 pills after breakfast, launch and dinner",
                            RefilAmmount = 5,
                            Cost = 140,
                            IsGeneric = false,
                            MedicationName = "Med9"
                        }
                    }
                },
                new Paitent() {
                    FirstName = "Tatha",
                    LastName = "Ones",
                    IsEnsured = false,
                    DateOfBirth = new DateTime(1967, 8, 10),
                    Medications = new List<Medication>(){
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 1",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 1",
                                Name = "Pharm 1",
                                State = "state 1"
                            },
                            Dose = 10,
                            Frequency = 3,
                            Instruction = "Take 1 after breakfast, launch and dinner",
                            RefilAmmount = 2,
                            Cost = 100,
                            IsGeneric = true,
                            MedicationName = "Med7"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 2",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 2",
                                Name = "Pharm 2",
                                State = "state 2"
                            },
                            Dose = 100,
                            Frequency = 3,
                            Instruction = "Take 2 pills after breakfast, launch and dinner",
                            RefilAmmount = 2,
                            Cost = 1000,
                            IsGeneric = true,
                            MedicationName = "Med"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 3",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 3",
                                Name = "Pharm 3",
                                State = "state 3"
                            },
                            Dose = 100,
                            Frequency = 3,
                            Instruction = "Take 3 pills after breakfast, launch and dinner",
                            RefilAmmount = 5,
                            Cost = 1000,
                            IsGeneric = true,
                            MedicationName = "Med9"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 3",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 3",
                                Name = "Pharm 3",
                                State = "state 3"
                            },
                            Dose = 1008,
                            Frequency = 3,
                            Instruction = "Take 3 pills after breakfast, launch and dinner",
                            RefilAmmount = 5,
                            Cost = 160,
                            IsGeneric = true,
                            MedicationName = "Med9"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 3",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 3",
                                Name = "Pharm 3",
                                State = "state 3"
                            },
                            Dose = 1008,
                            Frequency = 3,
                            Instruction = "Take 3 pills after breakfast, launch and dinner",
                            RefilAmmount = 5,
                            Cost = 140,
                            IsGeneric = false,
                            MedicationName = "Med9"
                        }
                    }
                },
                new Paitent() {
                    FirstName = "Tatha",
                    LastName = "Ones",
                    IsEnsured = false,
                    DateOfBirth = new DateTime(1967, 8, 10),
                    Medications = new List<Medication>(){
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 1",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 1",
                                Name = "Pharm 1",
                                State = "state 1"
                            },
                            Dose = 10,
                            Frequency = 3,
                            Instruction = "Take 1 after breakfast, launch and dinner",
                            RefilAmmount = 2,
                            Cost = 100,
                            IsGeneric = true,
                            MedicationName = "Med7"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 2",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 2",
                                Name = "Pharm 2",
                                State = "state 2"
                            },
                            Dose = 100,
                            Frequency = 3,
                            Instruction = "Take 2 pills after breakfast, launch and dinner",
                            RefilAmmount = 2,
                            Cost = 1000,
                            IsGeneric = true,
                            MedicationName = "Med"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 3",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 3",
                                Name = "Pharm 3",
                                State = "state 3"
                            },
                            Dose = 100,
                            Frequency = 3,
                            Instruction = "Take 3 pills after breakfast, launch and dinner",
                            RefilAmmount = 5,
                            Cost = 1000,
                            IsGeneric = true,
                            MedicationName = "Med9"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 3",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 3",
                                Name = "Pharm 3",
                                State = "state 3"
                            },
                            Dose = 1008,
                            Frequency = 3,
                            Instruction = "Take 3 pills after breakfast, launch and dinner",
                            RefilAmmount = 5,
                            Cost = 160,
                            IsGeneric = true,
                            MedicationName = "Med9"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 3",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 3",
                                Name = "Pharm 3",
                                State = "state 3"
                            },
                            Dose = 1008,
                            Frequency = 3,
                            Instruction = "Take 3 pills after breakfast, launch and dinner",
                            RefilAmmount = 5,
                            Cost = 140,
                            IsGeneric = false,
                            MedicationName = "Med9"
                        }
                    }
                },
                new Paitent() {
                    FirstName = "Tatha",
                    LastName = "Ones",
                    IsEnsured = false,
                    DateOfBirth = new DateTime(1967, 8, 10),
                    Medications = new List<Medication>(){
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 1",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 1",
                                Name = "Pharm 1",
                                State = "state 1"
                            },
                            Dose = 10,
                            Frequency = 3,
                            Instruction = "Take 1 after breakfast, launch and dinner",
                            RefilAmmount = 2,
                            Cost = 100,
                            IsGeneric = true,
                            MedicationName = "Med7"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 2",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 2",
                                Name = "Pharm 2",
                                State = "state 2"
                            },
                            Dose = 100,
                            Frequency = 3,
                            Instruction = "Take 2 pills after breakfast, launch and dinner",
                            RefilAmmount = 2,
                            Cost = 1000,
                            IsGeneric = true,
                            MedicationName = "Med"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 3",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 3",
                                Name = "Pharm 3",
                                State = "state 3"
                            },
                            Dose = 100,
                            Frequency = 3,
                            Instruction = "Take 3 pills after breakfast, launch and dinner",
                            RefilAmmount = 5,
                            Cost = 1000,
                            IsGeneric = true,
                            MedicationName = "Med9"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 3",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 3",
                                Name = "Pharm 3",
                                State = "state 3"
                            },
                            Dose = 1008,
                            Frequency = 3,
                            Instruction = "Take 3 pills after breakfast, launch and dinner",
                            RefilAmmount = 5,
                            Cost = 160,
                            IsGeneric = true,
                            MedicationName = "Med9"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 3",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 3",
                                Name = "Pharm 3",
                                State = "state 3"
                            },
                            Dose = 1008,
                            Frequency = 3,
                            Instruction = "Take 3 pills after breakfast, launch and dinner",
                            RefilAmmount = 5,
                            Cost = 140,
                            IsGeneric = false,
                            MedicationName = "Med9"
                        }
                    }
                },
                new Paitent() {
                    FirstName = "Tatha",
                    LastName = "Ones",
                    IsEnsured = false,
                    DateOfBirth = new DateTime(1967, 8, 10),
                    Medications = new List<Medication>(){
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 1",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 1",
                                Name = "Pharm 1",
                                State = "state 1"
                            },
                            Dose = 10,
                            Frequency = 3,
                            Instruction = "Take 1 after breakfast, launch and dinner",
                            RefilAmmount = 2,
                            Cost = 100,
                            IsGeneric = true,
                            MedicationName = "Med7"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 2",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 2",
                                Name = "Pharm 2",
                                State = "state 2"
                            },
                            Dose = 100,
                            Frequency = 3,
                            Instruction = "Take 2 pills after breakfast, launch and dinner",
                            RefilAmmount = 2,
                            Cost = 1000,
                            IsGeneric = true,
                            MedicationName = "Med"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 3",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 3",
                                Name = "Pharm 3",
                                State = "state 3"
                            },
                            Dose = 100,
                            Frequency = 3,
                            Instruction = "Take 3 pills after breakfast, launch and dinner",
                            RefilAmmount = 5,
                            Cost = 1000,
                            IsGeneric = true,
                            MedicationName = "Med9"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 3",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 3",
                                Name = "Pharm 3",
                                State = "state 3"
                            },
                            Dose = 1008,
                            Frequency = 3,
                            Instruction = "Take 3 pills after breakfast, launch and dinner",
                            RefilAmmount = 5,
                            Cost = 160,
                            IsGeneric = true,
                            MedicationName = "Med9"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 3",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 3",
                                Name = "Pharm 3",
                                State = "state 3"
                            },
                            Dose = 1008,
                            Frequency = 3,
                            Instruction = "Take 3 pills after breakfast, launch and dinner",
                            RefilAmmount = 5,
                            Cost = 140,
                            IsGeneric = false,
                            MedicationName = "Med9"
                        }
                    }
                },
                new Paitent() {
                    FirstName = "Tatha",
                    LastName = "Ones",
                    IsEnsured = false,
                    DateOfBirth = new DateTime(1967, 8, 10),
                    Medications = new List<Medication>(){
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 1",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 1",
                                Name = "Pharm 1",
                                State = "state 1"
                            },
                            Dose = 10,
                            Frequency = 3,
                            Instruction = "Take 1 after breakfast, launch and dinner",
                            RefilAmmount = 2,
                            Cost = 100,
                            IsGeneric = true,
                            MedicationName = "Med7"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 2",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 2",
                                Name = "Pharm 2",
                                State = "state 2"
                            },
                            Dose = 100,
                            Frequency = 3,
                            Instruction = "Take 2 pills after breakfast, launch and dinner",
                            RefilAmmount = 2,
                            Cost = 1000,
                            IsGeneric = true,
                            MedicationName = "Med"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 3",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 3",
                                Name = "Pharm 3",
                                State = "state 3"
                            },
                            Dose = 100,
                            Frequency = 3,
                            Instruction = "Take 3 pills after breakfast, launch and dinner",
                            RefilAmmount = 5,
                            Cost = 1000,
                            IsGeneric = true,
                            MedicationName = "Med9"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 3",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 3",
                                Name = "Pharm 3",
                                State = "state 3"
                            },
                            Dose = 1008,
                            Frequency = 3,
                            Instruction = "Take 3 pills after breakfast, launch and dinner",
                            RefilAmmount = 5,
                            Cost = 160,
                            IsGeneric = true,
                            MedicationName = "Med9"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 3",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 3",
                                Name = "Pharm 3",
                                State = "state 3"
                            },
                            Dose = 1008,
                            Frequency = 3,
                            Instruction = "Take 3 pills after breakfast, launch and dinner",
                            RefilAmmount = 5,
                            Cost = 140,
                            IsGeneric = false,
                            MedicationName = "Med9"
                        }
                    }
                },
                new Paitent() {
                    FirstName = "Tatha",
                    LastName = "Ones",
                    IsEnsured = false,
                    DateOfBirth = new DateTime(1967, 8, 10),
                    Medications = new List<Medication>(){
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 1",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 1",
                                Name = "Pharm 1",
                                State = "state 1"
                            },
                            Dose = 10,
                            Frequency = 3,
                            Instruction = "Take 1 after breakfast, launch and dinner",
                            RefilAmmount = 2,
                            Cost = 100,
                            IsGeneric = true,
                            MedicationName = "Med7"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 2",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 2",
                                Name = "Pharm 2",
                                State = "state 2"
                            },
                            Dose = 100,
                            Frequency = 3,
                            Instruction = "Take 2 pills after breakfast, launch and dinner",
                            RefilAmmount = 2,
                            Cost = 1000,
                            IsGeneric = true,
                            MedicationName = "Med"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 3",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 3",
                                Name = "Pharm 3",
                                State = "state 3"
                            },
                            Dose = 100,
                            Frequency = 3,
                            Instruction = "Take 3 pills after breakfast, launch and dinner",
                            RefilAmmount = 5,
                            Cost = 1000,
                            IsGeneric = true,
                            MedicationName = "Med9"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 3",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 3",
                                Name = "Pharm 3",
                                State = "state 3"
                            },
                            Dose = 1008,
                            Frequency = 3,
                            Instruction = "Take 3 pills after breakfast, launch and dinner",
                            RefilAmmount = 5,
                            Cost = 160,
                            IsGeneric = true,
                            MedicationName = "Med9"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 3",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 3",
                                Name = "Pharm 3",
                                State = "state 3"
                            },
                            Dose = 1008,
                            Frequency = 3,
                            Instruction = "Take 3 pills after breakfast, launch and dinner",
                            RefilAmmount = 5,
                            Cost = 140,
                            IsGeneric = false,
                            MedicationName = "Med9"
                        }
                    }
                },
                new Paitent() {
                    FirstName = "Tatha",
                    LastName = "Ones",
                    IsEnsured = false,
                    DateOfBirth = new DateTime(1967, 8, 10),
                    Medications = new List<Medication>(){
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 1",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 1",
                                Name = "Pharm 1",
                                State = "state 1"
                            },
                            Dose = 10,
                            Frequency = 3,
                            Instruction = "Take 1 after breakfast, launch and dinner",
                            RefilAmmount = 2,
                            Cost = 100,
                            IsGeneric = true,
                            MedicationName = "Med7"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 2",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 2",
                                Name = "Pharm 2",
                                State = "state 2"
                            },
                            Dose = 100,
                            Frequency = 3,
                            Instruction = "Take 2 pills after breakfast, launch and dinner",
                            RefilAmmount = 2,
                            Cost = 1000,
                            IsGeneric = true,
                            MedicationName = "Med"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 3",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 3",
                                Name = "Pharm 3",
                                State = "state 3"
                            },
                            Dose = 100,
                            Frequency = 3,
                            Instruction = "Take 3 pills after breakfast, launch and dinner",
                            RefilAmmount = 5,
                            Cost = 1000,
                            IsGeneric = true,
                            MedicationName = "Med9"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 3",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 3",
                                Name = "Pharm 3",
                                State = "state 3"
                            },
                            Dose = 1008,
                            Frequency = 3,
                            Instruction = "Take 3 pills after breakfast, launch and dinner",
                            RefilAmmount = 5,
                            Cost = 160,
                            IsGeneric = true,
                            MedicationName = "Med9"
                        },
                        new Medication() {
                            Prescriber = new Doctor(){
                                FirstName = "Doc 3",
                                LastName = "Doclname"
                            },
                            Pharmacy = new Pharmacy() {
                                City = "City 3",
                                Name = "Pharm 3",
                                State = "state 3"
                            },
                            Dose = 1008,
                            Frequency = 3,
                            Instruction = "Take 3 pills after breakfast, launch and dinner",
                            RefilAmmount = 5,
                            Cost = 140,
                            IsGeneric = false,
                            MedicationName = "Med9"
                        }
                    }
                }
            });
            await context.SaveChangesAsync();
        }
        catch
        {              
        }

    }
}
