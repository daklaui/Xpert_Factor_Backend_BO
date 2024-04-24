using CleanArc.Application.Common;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Contracts.Persistence
{
    public interface IListValueRepository 
    {
        Task AddListValueAsync(TR_LIST_VAL listValue);
        Task<PagedList<TR_LIST_VAL>> GetAllListValuesAsync(PaginationParams paginationParams);
        Task<TR_LIST_VAL> GetListValueById(int id);
        Task<bool> UpdateListValueAsync(int id, TR_LIST_VAL updatedListValue);
    }
}
