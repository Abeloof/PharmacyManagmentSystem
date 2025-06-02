using PMS.Common.Dtos.Medication;

namespace PMS.Common.Dtos.Patient;

public class GetPaitentDto
{
    public int PatientId { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public int? InsuranceId { get; set; }
    public bool IsEnsured { get; set; }
    public IList<GetMedicationDto> Medications { get; set; } = new List<GetMedicationDto>();
}
