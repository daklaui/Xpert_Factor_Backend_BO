using CleanArc.Application.Common;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Contracts.Persistence;

public interface ITjcirRepository
{
    //Task AddICIRlAsync(TJ_CIR buyer);
    
    Task<TJ_CIR> AddTJCIRsync( TJ_CIR Buyer);
    
    //Task<PagedList<TJ_CIR>> GetAllCIRAsync(PaginationParams paginationParams);
    //Task<TJ_CIR> GetCIRById(int id);
    //Task<List<Individu>> GetAllOrdersWithRelatedUserAsync();
}