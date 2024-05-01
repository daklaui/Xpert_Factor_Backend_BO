using System.Threading.Tasks;
using CleanArc.Application.Common;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Contracts.Persistence
{
    public interface IIntFinanceRepository
    {
        Task AddIntFinanceAsync(T_INT_FINANCEMENT intFinance);
        Task<PagedList<T_INT_FINANCEMENT>> GetAllIntFinanceAsync(PaginationParams paginationParams);
        Task<List<T_INT_FINANCEMENT>> GetIntFinanceById(int id);
        Task<T_INT_FINANCEMENT> GetIntFinanceByRefCtrAndType(int refCtr, string Type);
        Task<bool> UpdateIntFinanceAsync(int intFinanceId, T_INT_FINANCEMENT updatedIntFinance);
    }
}