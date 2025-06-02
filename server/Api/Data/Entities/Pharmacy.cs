using Api.Domain;

namespace Api.Data.Entities;

public class Pharmacy : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string State { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public ICollection<Medication> Medications { get; set; } = new List<Medication>();

}
