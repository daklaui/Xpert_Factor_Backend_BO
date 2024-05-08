using CleanArc.Application.Common;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Contracts.Persistence
{
    public interface IFactoringCommissionRepository
    {
        Task AddFactoringCommissionAsync(T_COMM_FACTORING factoringCommission);
        Task<PagedList<T_COMM_FACTORING>> GetAllFactoringCommissionsAsync(PaginationParams paginationParams);
        Task<List<T_COMM_FACTORING>> GetFactoringCommissionById(int id);
        Task<T_COMM_FACTORING> GetCommFactoringByRefCtrAndType(int id, string type);
        Task<bool> UpdateFactoringCommissionAsync(int id, T_COMM_FACTORING updatedFactoringCommission);
    }
}