namespace PMS.Common.Dtos.Medication;

public record DoctorDto(int Id, string FirstName, string LastName, string Speciality);
public record PharmacyDto(int Id, string Name, string State, string City);
public class GetMedicationDto
{
    public GetMedicationDto(DoctorDto? prescriber = null, PharmacyDto? pharmacy= null)
    {
        Prescriber = prescriber;
        Pharmacy = pharmacy;
    }
    public int MedicationId { get; set; }
    public string MedicationName { get; set; } = string.Empty;
    public int Dose { get; set; }
    public string Instruction { get; set; } = string.Empty;
    public int RefilAmmount { get; set; }
    public int Frequency { get; set; }
    public decimal Cost { get; set; }
    public bool IsGeneric { get; set; }
    public int PaitentId { get; set; }
    public int PrescriberId { get; set; }
    public int PharmacyId { get; set; }
    public DoctorDto? Prescriber { get; set; }
    public PharmacyDto? Pharmacy { get; set; }
}
