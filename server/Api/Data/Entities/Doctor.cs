using Api.Domain;

namespace Api.Data.Entities;

public class Doctor : BaseEntity
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Speciality { get; set; } = string.Empty;
    public ICollection<Medication> Medications { get; set; } = new List<Medication>();
}
