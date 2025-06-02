namespace PMS.Common.Entities;

public class Paitent : BaseEntity
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public int? InsuranceId { get; set; }
    public bool IsEnsured { get; set; }
    public ICollection<Medication> Medications { get; set; } = new List<Medication>();
}
