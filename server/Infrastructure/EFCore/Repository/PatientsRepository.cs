using Microsoft.EntityFrameworkCore;
using PMS.Common.Entities;
using PMS.Core.Interfaces;
using PMS.Infrastructure.EFCore;

namespace PMS.Infrastructure.EFCore.Repository;

public class PaitentsRepository(PMSDbContext employeesDbContext) : IRepository<Paitent>
{
    public async Task<Paitent?> Add(Paitent paitent, CancellationToken cancellationToken = default)
    {
        await employeesDbContext.AddAsync(paitent);
        var id = await employeesDbContext.SaveChangesAsync();
        return await GetByIdAsync(id, cancellationToken);
    }

    public async Task<Paitent?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
    {
        var employee = await employeesDbContext.Paitents.Include(x => x.Medications)
                                                .ThenInclude(x => x.Prescriber)
                                                .Include(x => x.Medications)
                                                .ThenInclude(x => x.Pharmacy)
                                                    .FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
        return employee;
    }

    public async Task<IList<Paitent>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        var employees = await employeesDbContext.Paitents.Include(x => x.Medications)
                                                .ThenInclude(x => x.Prescriber)
                                                .Include(x => x.Medications)
                                                .ThenInclude(x => x.Pharmacy)
                                                    .ToArrayAsync(cancellationToken);
        return employees;
    }
}