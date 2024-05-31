using CleanArc.Application.Common;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Contracts.Persistence;

public interface IListValRepository
{
    Task<List<TR_LIST_VAL>> GetAllRecouvrementAsync();
    Task<List<TR_LIST_VAL>> GetFormJuridique();
    Task<TR_LIST_VAL> AddTListValAsync(TR_LIST_VAL listVal);
    Task<PagedList<TR_LIST_VAL>> GetAllTListValsAsync(PaginationParams paginationParams);
    Task<TR_LIST_VAL> GetTListValById(int id);
    Task<TR_LIST_VAL> UpdateTListValAsync(int id, TR_LIST_VAL updatedTListVal);
}