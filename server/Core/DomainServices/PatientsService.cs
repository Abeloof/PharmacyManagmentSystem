using PMS.Common.Dtos.Medication;
using PMS.Common.Dtos.Patient;
using PMS.Common.Entities;
using PMS.Core.Interfaces;

namespace Api.Domain.DomainServices;

public class PatientsService(IRepository<Paitent> paitentsRepository) : IPatientsService
{
    public async Task<GetPaitentDto?> GetPaitentAsync(int id, CancellationToken cancellationToken = default)
    {
        var patientEntity = await paitentsRepository.GetByIdAsync(id, cancellationToken);
        return MapPaitentEntityToGetPaitentDto(patientEntity);
    }

    public async Task<IList<GetPaitentDto>> GetPaitentsAsync(CancellationToken cancellationToken = default)
    {
        var employeesEntities = await paitentsRepository.GetAllAsync(cancellationToken);
        if (!employeesEntities.Any()) return new List<GetPaitentDto>();
        return [.. employeesEntities.Select(MapPaitentEntityToGetPaitentDto)!];
    }
    
    public async Task<GetPaitentDto?> CreatePatientAsync(GetPaitentDto patient, CancellationToken cancellationToken = default)
    {
        var entity = await paitentsRepository.Add(MapGetPaitentDto(patient), cancellationToken);
        return MapPaitentEntityToGetPaitentDto(entity);
    }

    private Paitent MapGetPaitentDto(GetPaitentDto paitentDto)
    {
        return new Paitent()
        {
            Id = paitentDto.PatientId,
            DateOfBirth = paitentDto.DateOfBirth,
            FirstName = paitentDto.FirstName,
            LastName = paitentDto.LastName,
            InsuranceId = paitentDto.InsuranceId,
            IsEnsured = paitentDto.InsuranceId != 0,
            Medications = [.. paitentDto.Medications.Select(m => new Medication(){
                Cost = m.Cost,
                Dose = m.Dose,
                Frequency =m.Frequency,
                Id = m.MedicationId,
                Instruction = m.Instruction,
                IsGeneric = m.IsGeneric,
                MedicationName = m.MedicationName,
                PaitentId = m.PaitentId,
                PrescriberId = m.PrescriberId,
                PharmacyId = m.PharmacyId,
                Prescriber = m.Prescriber == null ? new Doctor() : new Doctor(){
                    FirstName = m.Prescriber.FirstName,
                    LastName = m.Prescriber.LastName,
                    Id = m.Prescriber.Id,
                    Speciality = m.Prescriber.Speciality
                },
                Pharmacy = m.Pharmacy == null ? new Pharmacy() : new Pharmacy() {
                    City = m.Pharmacy.City,
                    Name = m.Pharmacy.Name,
                    State = m.Pharmacy.State
                }
            })]
        };
    }
    private GetPaitentDto? MapPaitentEntityToGetPaitentDto(Paitent? paitentEntity)
    {
        if (paitentEntity == null) return null;
        return new GetPaitentDto()
        {
            PatientId = paitentEntity.Id,
            DateOfBirth = paitentEntity.DateOfBirth,
            FirstName = paitentEntity.FirstName,
            LastName = paitentEntity.LastName,
            IsEnsured = paitentEntity.IsEnsured,
            InsuranceId = paitentEntity.InsuranceId,
            Medications = [.. paitentEntity.Medications.Select(n => new GetMedicationDto(
                new DoctorDto(n.Prescriber.Id, n.Prescriber.FirstName, n.Prescriber.LastName, n.Prescriber.Speciality),
                new PharmacyDto(n.Pharmacy.Id, n.Pharmacy.Name, n.Pharmacy.State, n.Pharmacy.City)){
                    Dose = n.Dose,
                    Cost = n.Cost,
                    MedicationName = n.MedicationName,
                    Frequency = n.Frequency,
                    Instruction = n.Instruction,
                    RefilAmmount = n.RefilAmmount,
                    MedicationId = n.Id,
                    PharmacyId = n.PharmacyId,
                    PrescriberId = n.PrescriberId,
                    PaitentId = n.PaitentId,
                    IsGeneric = n.IsGeneric
                })
            ]
        };
    }    
}
