using PMS.Common.Dtos.Patient;

namespace PMS.Core.Interfaces;

public interface IPatientsService
{
    Task<GetPaitentDto?> CreatePatientAsync(GetPaitentDto patient, CancellationToken cancellationToken = default);
    /// <summary>
    /// Returns all Paitents.
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns>List of Paitent</returns>
    Task<IList<GetPaitentDto>> GetPaitentsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns an Paitent whois Paitent id matchs request's id.
    /// </summary>
    /// <param name="id">Requests Paitent id</param>
    /// <param name="cancellationToken"></param>
    /// <returns>an Paitent</returns>
    Task<GetPaitentDto?> GetPaitentAsync(int id, CancellationToken cancellationToken = default);
}
