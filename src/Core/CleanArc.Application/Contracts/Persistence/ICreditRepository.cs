using CleanArc.Application.Common;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Contracts.Persistence;

public interface ICreditRepository
{
    Task AddICreditAsync(T_MVT_CREDIT Credit);
    Task<PagedList<T_MVT_CREDIT>> GetAllCreditAsync(PaginationParams paginationParams);
    Task<T_MVT_CREDIT> GetCreditById(int id);
    Task<bool> UpdateCreditAsync(int id, T_MVT_CREDIT updatedCredit);

}