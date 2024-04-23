using CleanArc.Application.Common;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Contracts.Persistence;

public interface IFinancementRepository
{
    Task<PagedList<T_FINANCEMENT>> GetAllFinancementAsync(PaginationParams paginationParams);
    Task<T_FINANCEMENT> AddFinanceAsync(T_FINANCEMENT finance);
    Task<T_FINANCEMENT> GetFinanceById(int id);
    Task <T_FINANCEMENT> ValidateFinanceAsync(int id ,T_FINANCEMENT finance);
    Task <T_FINANCEMENT> RejectFinanceAsync(int id ,T_FINANCEMENT finance);

}