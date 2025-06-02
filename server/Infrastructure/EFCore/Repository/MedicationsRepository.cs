using Microsoft.EntityFrameworkCore;
using PMS.Common.Entities;
using PMS.Core.Interfaces;
using PMS.Infrastructure.EFCore;

namespace PMS.Infrastructure.EFCore.Repository;

public class MedicationsRepository(PMSDbContext employeesDbContext) : IRepository<Medication>
{
    public Task<Medication?> Add(Medication entitty, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public async Task<IList<Medication>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        var medications = await employeesDbContext.Medications.Include(x => x.Paitent)
                                                    .Include(x => x.Pharmacy)
                                                    .Include(x => x.Prescriber)
                                                    .ToArrayAsync(cancellationToken);
        return medications;
    }

    public async Task<Medication?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
    {
        var medication = await employeesDbContext.Medications.Include(x => x.Paitent)
                                                    .Include(x => x.Pharmacy)
                                                    .Include(x => x.Prescriber)
                                                    .FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
        return medication;
    }
}
