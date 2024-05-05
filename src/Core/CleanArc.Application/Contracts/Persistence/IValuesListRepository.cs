using CleanArc.Application.Common;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Contracts.Persistence;

public interface IValuesListRepository
{
    Task <TR_LIST_VAL> AddListValAsync(TR_LIST_VAL listVal);
    Task UpdateListValAsync(TR_LIST_VAL listVal); 
    
    Task<PagedList<TR_LIST_VAL>> GetFormJuridiqueList(PaginationParams paginationParams);
    
    Task<PagedList<TR_LIST_VAL>> GetContactsList (PaginationParams paginationParams);

    Task<PagedList<TR_NLDP>> GetLangList (PaginationParams paginationParams );
    
    
}