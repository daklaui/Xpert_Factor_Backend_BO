using CleanArc.Application.Common;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Contracts.Persistence;

public interface ITMMRepository
{
    Task <TR_TMM> AddTrTmmAsync(TR_TMM trTmm);
    Task<PagedList<TR_TMM>> GetAllTrTmmAsync(PaginationParams paginationParams);
    Task<TR_TMM> GetTrTmmById(int id);
    Task UpdateTrTmmAsync(TR_TMM trTmm);    
}