using System.Net;
using System.Net.Http.Json;
using Api.Domain.Dtos.Medication;
using Api.Domain.Dtos.Patient;
using Xunit;

namespace Tests.IntegrationTests;

public class PaitentsIntegrationTests : IntegrationTest
{
    [Fact]
    public async Task WhenAskedForAPatient_Should_Succeed()
    {
        var response = await HttpClient.GetAsync("/api/v1/Paitents/1");
        var dependents = new GetPaitentDto
        {
            PatientId = 1,
            FirstName = "Ja",
            LastName = "Morant",
            DateOfBirth = new DateTime(1999, 08, 10),
            InsuranceId = 12,
            IsEnsured = true,
            Medications = new List<GetMedicationDto>()
            {
                new GetMedicationDto(new DoctorDto(1, "Doc 1", "Doclname", ""), new PharmacyDto(1, "Pharm 1", "state 1", "City 1")) {
                    Cost = 300.00m, Dose = 10, Frequency = 3, Instruction = "Take 1 after breakfast, launch and dinner", IsGeneric = false,
                    MedicationId = 1, MedicationName = "Med1", PaitentId=1, PharmacyId = 1, PrescriberId = 1, RefilAmmount = 2
                 },
                 new GetMedicationDto(new DoctorDto(2, "Doc 2", "Doclname", ""), new PharmacyDto(2, "Pharm 2", "state 2", "City 2")) {
                    Cost = 0.00m, Dose=100, Frequency = 3, Instruction = "Take 2 pills after breakfast, launch and dinner", IsGeneric = false,
                    MedicationId = 2, MedicationName = "", PaitentId = 1, PharmacyId = 2, PrescriberId = 2, RefilAmmount = 2
                 },
                 new GetMedicationDto(new DoctorDto(3, "Doc 3", "Doclname", ""), new PharmacyDto(3, "Pharm 3", "state 3", "City 3")) {
                    Cost = 0.00m, Dose = 100, Frequency = 3, Instruction="Take 3 pills after breakfast, launch and dinner", IsGeneric=false,
                    MedicationId=3, MedicationName="", PaitentId=1, PharmacyId=3, PrescriberId=3, RefilAmmount=5
                 }
            }
        };
        await response.ShouldReturn(HttpStatusCode.OK, dependents);
    }

    [Fact]
    public async Task WhenAskedToCreate_A_Patient_Should_Succed()
    {
        var patient = new GetPaitentDto
        {
            FirstName = "Ja",
            LastName = "Morat",
            DateOfBirth = new DateTime(1999, 08, 10),
            InsuranceId = 12,
            IsEnsured = true,
            Medications = new List<GetMedicationDto>()
            {
                new GetMedicationDto() {
                    Cost = 300.00m, Dose = 10, Frequency = 3, Instruction = "Take 1 after breakfast, launch and dinner", IsGeneric = false,
                    MedicationName = "Med1", PharmacyId = 1, PrescriberId = 1, RefilAmmount = 2
                 }
            }
        };
        var response = await HttpClient.PostAsync("/api/v1/Paitents", JsonContent.Create(patient));
        await response.ShouldReturn(HttpStatusCode.OK);
    }

}

