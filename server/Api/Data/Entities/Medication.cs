using Api.Domain;

namespace Api.Data.Entities;

public class Medication : BaseEntity
{
    public string MedicationName { get; set; } = string.Empty;
    public int Dose { get; set; }
    public decimal Cost { get; set; }
    public bool IsGeneric { get; set; }
    public string Instruction { get; set; } = string.Empty;
    public int RefilAmmount { get; set; }
    public int Frequency { get; set; }
    public Paitent Paitent { get; set; } = new Paitent();
    public Doctor Prescriber { get; set; } = new Doctor();
    public Pharmacy Pharmacy { get; set; } = new Pharmacy();
    public int PaitentId { get; set; }
    public int PrescriberId { get; set; }
    public int PharmacyId { get; set; }
}
