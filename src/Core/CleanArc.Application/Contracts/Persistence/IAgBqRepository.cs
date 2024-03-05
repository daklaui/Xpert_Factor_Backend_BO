using CleanArc.Application.Common;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Contracts.Persistence;

public interface IAgBqRepository
{
    Task<TRAgBq> GetAgBqByIdAsync(int id);
    Task<PagedList<TRAgBq>> GetAllAgBqAsync(PaginationParams paginationParams);
    Task AddAgBqAsync(TRAgBq agBq);
    Task UpdateAgBqAsync(TRAgBq agBq);
}