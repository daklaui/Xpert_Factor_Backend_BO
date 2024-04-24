using CleanArc.Application.Common;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Contracts.Persistence
{
    public interface IContratRepository
    {
        Task AddContratAsync(T_CONTRAT contrat);
        Task<PagedList<T_CONTRAT>> GetAllContratsAsync(PaginationParams paginationParams);
        Task<T_CONTRAT> GetContratById(int id);
        Task<bool> UpdateContratAsync(int id, T_CONTRAT updatedContrat);
        
        Task<int> GetContractsForCurrentYearasync();
    }
}
