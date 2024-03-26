using CleanArc.Application.Common;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Contracts.Persistence;

public interface IBordereauxRepository
{
    Task addBordereauxAsync(T_BORDEREAU bordereau);
    
    Task<PagedList<T_BORDEREAU>> GetAllBordereauxAsync(PaginationParams paginationParams);

    Task<T_BORDEREAU> GetBordereauxById(string id);
    
    Task DeleteBordereaux(T_BORDEREAU bordereau);
}