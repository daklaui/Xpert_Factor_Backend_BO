using CleanArc.Application.Common;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Contracts.Persistence;

public interface IT_DET_BORD_Repository
{
    Task addT_DET_BORD_Async(T_DET_BORD detBord);

    Task<PagedList<T_DET_BORD>> GetAllT_DET_BORD_Async(PaginationParams paginationParams);

    Task<T_DET_BORD> GetT_DET_BORD_Byid(string id);

    Task DeleteT_DET_BORD(T_DET_BORD detBord);
}