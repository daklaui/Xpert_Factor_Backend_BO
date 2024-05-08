using CleanArc.Application.Common;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Contracts.Persistence
{
    public interface ITR_CPRepository
    {
        Task AddTR_CPAsync(TR_CP tr_cp);
        Task<PagedList<TR_CP>> GetAllTR_CPsAsync(PaginationParams paginationParams);
        Task<TR_CP> GetTR_CPById(int id);
        Task<bool> UpdateTR_CPAsync(int id, TR_CP updatedTR_CP);
    }
}
